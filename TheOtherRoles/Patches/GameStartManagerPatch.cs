  
using HarmonyLib;
using UnityEngine;
using System.Reflection;
using System.Collections.Generic;
using Hazel;
using System;
using TheOtherRoles.Players;
using TheOtherRoles.Utilities;

namespace TheOtherRoles.Patches {
    public class GameStartManagerPatch  {
        public static Dictionary<int, PlayerVersion> playerVersions = new Dictionary<int, PlayerVersion>();
        public static float timer = 600f;
        private static float kickingTimer = 0f;
        private static bool versionSent = false;
        private static string lobbyCodeText = "";

        [HarmonyPatch(typeof(AmongUsClient), nameof(AmongUsClient.OnPlayerJoined))]
        public class AmongUsClientOnPlayerJoinedPatch {
            public static void Postfix() {
                if (CachedPlayer.LocalPlayer != null) {
                    Helpers.shareGameVersion();
                }
            }
        }

        [HarmonyPatch(typeof(GameStartManager), nameof(GameStartManager.Start))]
        public class GameStartManagerStartPatch {
            public static void Postfix(GameStartManager __instance) {
                // Trigger version refresh
                versionSent = false;
                // Reset lobby countdown timer
                timer = 600f; 
                // Reset kicking timer
                kickingTimer = 0f;
                // Copy lobby code
                string code = InnerNet.GameCode.IntToGameName(AmongUsClient.Instance.GameId);
                GUIUtility.systemCopyBuffer = code;
                lobbyCodeText = FastDestroyableSingleton<TranslationController>.Instance.GetString(StringNames.RoomCode, new Il2CppReferenceArray<Il2CppSystem.Object>(0)) + "\r\n" + code;
            }
        }

        [HarmonyPatch(typeof(GameStartManager), nameof(GameStartManager.Update))]
        public class GameStartManagerUpdatePatch {
            private static bool update = false;
            private static string currentText = "";
        
            public static void Prefix(GameStartManager __instance) {
                if (!GameData.Instance ) return; // No instance
                update = GameData.Instance.PlayerCount != __instance.LastPlayerCount;
            }

            public static void Postfix(GameStartManager __instance) {
                // Send version as soon as CachedPlayer.LocalPlayer.PlayerControl exists
                if (PlayerControl.LocalPlayer != null && !versionSent) {
                    versionSent = true;
                    Helpers.shareGameVersion();
                }

                // Check version handshake infos
                
                bool versionMismatch = false;
                string message = "";
                foreach (InnerNet.ClientData client in AmongUsClient.Instance.allClients.ToArray()) {
                    if (client.Character == null) continue;
                    var dummyComponent = client.Character.GetComponent<DummyBehaviour>();
                    if (dummyComponent != null && dummyComponent.enabled)
                        continue;
                    else if (!playerVersions.ContainsKey(client.Id))  {
                        versionMismatch = true;
                        message += $"<color=#FF0000FF>{client.Character.Data.PlayerName} a une version diff�rente ou n'a pas The Other Roles\n</color>";
                    } else {
                        PlayerVersion PV = playerVersions[client.Id];
                        int diff = TheOtherRolesPlugin.Version.CompareTo(PV.version);
                        if (diff > 0) {
                            message += $"<color=#FF0000FF>{client.Character.Data.PlayerName} a une version plus vieille de The Other Roles (v{playerVersions[client.Id].version.ToString()})\n</color>";
                            versionMismatch = true;
                        } else if (diff < 0) {
                            message += $"<color=#FF0000FF>{client.Character.Data.PlayerName} has a newer version of The Other Roles (v{playerVersions[client.Id].version.ToString()})\n</color>";
                            versionMismatch = true;
                        } else if (!PV.GuidMatches()) { // version presumably matches, check if Guid matches
                            message += $"<color=#FF0000FF>{client.Character.Data.PlayerName} a une version modifi�e de TOR v{playerVersions[client.Id].version.ToString()} <size=30%>({PV.guid.ToString()})</size>\n</color>";
                            versionMismatch = true;
                        }
                    }
                }

                // Display message to the host
                if (AmongUsClient.Instance.AmHost) {
                    if (versionMismatch) {
                        __instance.StartButton.color = __instance.startLabelText.color = Palette.DisabledClear;
                        __instance.GameStartText.text = message;
                        __instance.GameStartText.transform.localPosition = __instance.StartButton.transform.localPosition + Vector3.up * 2;
                    } else {
                        __instance.StartButton.color = __instance.startLabelText.color = ((__instance.LastPlayerCount >= __instance.MinPlayers) ? Palette.EnabledColor : Palette.DisabledClear);
                        __instance.GameStartText.transform.localPosition = __instance.StartButton.transform.localPosition;
                    }
                }

                // Client update with handshake infos
                else {
                    if (!playerVersions.ContainsKey(AmongUsClient.Instance.HostId) || TheOtherRolesPlugin.Version.CompareTo(playerVersions[AmongUsClient.Instance.HostId].version) != 0) {
                        kickingTimer += Time.deltaTime;
                        if (kickingTimer > 10) {
                            kickingTimer = 0;
			                AmongUsClient.Instance.ExitGame(DisconnectReasons.ExitGame);
                            SceneChanger.ChangeScene("MainMenu");
                        }

                        __instance.GameStartText.text = $"<color=#FF0000FF>L'h�te n'a pas ou a une version diff�rente de The Other Roles\nVous serez kick dans {Math.Round(10 - kickingTimer)}s</color>";
                        __instance.GameStartText.transform.localPosition = __instance.StartButton.transform.localPosition + Vector3.up * 2;
                    } else if (versionMismatch) {
                        __instance.GameStartText.text = $"<color=#FF0000FF>Joueurs avec une version diff�rente:\n</color>" + message;
                        __instance.GameStartText.transform.localPosition = __instance.StartButton.transform.localPosition + Vector3.up * 2;
                    } else {
                        __instance.GameStartText.transform.localPosition = __instance.StartButton.transform.localPosition;
                        if (__instance.startState != GameStartManager.StartingStates.Countdown) {
                            __instance.GameStartText.text = String.Empty;
                        }
                    }
                }

                // Lobby timer
                if (!GameData.Instance) return; // No instance

                if (update) currentText = __instance.PlayerCounter.text;

                timer = Mathf.Max(0f, timer -= Time.deltaTime);
                int minutes = (int)timer / 60;
                int seconds = (int)timer % 60;
                string suffix = $" ({minutes:00}:{seconds:00})";

                __instance.PlayerCounter.text = currentText + suffix;
                __instance.PlayerCounter.autoSizeTextContainer = true;

            }
        }

        [HarmonyPatch(typeof(GameStartManager), nameof(GameStartManager.BeginGame))]
        public class GameStartManagerBeginGame {
            public static bool Prefix(GameStartManager __instance) {
                // Block game start if not everyone has the same mod version
                bool continueStart = true;

                if (AmongUsClient.Instance.AmHost) {
                    foreach (InnerNet.ClientData client in AmongUsClient.Instance.allClients.GetFastEnumerator()) {
                        if (client.Character == null) continue;
                        var dummyComponent = client.Character.GetComponent<DummyBehaviour>();
                        if (dummyComponent != null && dummyComponent.enabled)
                            continue;
                        
                        if (!playerVersions.ContainsKey(client.Id)) {
                            continueStart = false;
                            break;
                        }
                        
                        PlayerVersion PV = playerVersions[client.Id];
                        int diff = TheOtherRolesPlugin.Version.CompareTo(PV.version);
                        if (diff != 0 || !PV.GuidMatches()) {
                            continueStart = false;
                            break;
                        }
                    }

                    if (CustomOptionHolder.dynamicMap.getBool() && continueStart) {
                        // 0 = Skeld
                        // 1 = Mira HQ
                        // 2 = Polus
                        // 3 = Dleks - deactivated
                        // 4 = Airship
                        List<byte> possibleMaps = new List<byte>();
                        if (CustomOptionHolder.dynamicMapEnableSkeld.getBool())
                            possibleMaps.Add(0);
                        if (CustomOptionHolder.dynamicMapEnableMira.getBool())
                            possibleMaps.Add(1);
                        if (CustomOptionHolder.dynamicMapEnablePolus.getBool())
                            possibleMaps.Add(2);
                        if (CustomOptionHolder.dynamicMapEnableAirShip.getBool())
                            possibleMaps.Add(4);
                        if (CustomOptionHolder.dynamicMapEnableSubmerged.getBool())
                            possibleMaps.Add(5);
                        byte chosenMapId  = possibleMaps[TheOtherRoles.rnd.Next(possibleMaps.Count)];

                        MessageWriter writer = AmongUsClient.Instance.StartRpcImmediately(CachedPlayer.LocalPlayer.PlayerControl.NetId, (byte)CustomRPC.DynamicMapOption, Hazel.SendOption.Reliable, -1);
                        writer.Write(chosenMapId);
                        AmongUsClient.Instance.FinishRpcImmediately(writer);
                        RPCProcedure.dynamicMapOption(chosenMapId);
                    }
                }
                return continueStart;
            }
        }

        public class PlayerVersion {
            public readonly Version version;
            public readonly Guid guid;

            public PlayerVersion(Version version, Guid guid) {
                this.version = version;
                this.guid = guid;
            }

            public bool GuidMatches() {
                return Assembly.GetExecutingAssembly().ManifestModule.ModuleVersionId.Equals(this.guid);
            }
        }
    }
}
