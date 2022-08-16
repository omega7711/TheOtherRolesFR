using System;
using System.Collections.Generic;
using HarmonyLib;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.UI.Button;
using Object = UnityEngine.Object;
using TheOtherRoles.Patches;

namespace TheOtherRoles.Modules {
    [HarmonyPatch(typeof(MainMenuManager), nameof(MainMenuManager.Start))]
    public class MainMenuPatch {
        private static bool horseButtonState = MapOptions.enableHorseMode;
        private static Sprite horseModeOffSprite = null;
        private static Sprite horseModeOnSprite = null;
        private static GameObject bottomTemplate;
        private static AnnouncementPopUp popUp;

        private static void Prefix(MainMenuManager __instance) {
            CustomHatLoader.LaunchHatFetcher();
            var template = GameObject.Find("ExitGameButton");
            if (template == null) return;

            var buttonDiscord = UnityEngine.Object.Instantiate(template, null);
            buttonDiscord.transform.localPosition = new Vector3(buttonDiscord.transform.localPosition.x, buttonDiscord.transform.localPosition.y + 0.6f, buttonDiscord.transform.localPosition.z);

            var textDiscord = buttonDiscord.transform.GetChild(0).GetComponent<TMPro.TMP_Text>();
            __instance.StartCoroutine(Effects.Lerp(0.1f, new System.Action<float>((p) => {
                textDiscord.SetText("Discord");
            })));

            PassiveButton passiveButtonDiscord = buttonDiscord.GetComponent<PassiveButton>();
            SpriteRenderer buttonSpriteDiscord = buttonDiscord.GetComponent<SpriteRenderer>();

            passiveButtonDiscord.OnClick = new Button.ButtonClickedEvent();
            passiveButtonDiscord.OnClick.AddListener((System.Action)(() => Application.OpenURL("https://discord.gg/77RkMJHWsM")));

            Color discordColor = new Color32(88, 101, 242, byte.MaxValue);
            buttonSpriteDiscord.color = textDiscord.color = discordColor;
            passiveButtonDiscord.OnMouseOut.AddListener((System.Action)delegate {
                buttonSpriteDiscord.color = textDiscord.color = discordColor;
            });


            // Horse mode stuff
            var horseModeSelectionBehavior = new ClientOptionsPatch.SelectionBehaviour("Enable Horse Mode", () => MapOptions.enableHorseMode = TheOtherRolesPlugin.EnableHorseMode.Value = !TheOtherRolesPlugin.EnableHorseMode.Value, TheOtherRolesPlugin.EnableHorseMode.Value);

            bottomTemplate = GameObject.Find("InventoryButton");
            if (bottomTemplate == null) return;
            var horseButton = Object.Instantiate(bottomTemplate, bottomTemplate.transform.parent);
            var passiveHorseButton = horseButton.GetComponent<PassiveButton>();
            var spriteHorseButton = horseButton.GetComponent<SpriteRenderer>();

            horseModeOffSprite = Helpers.loadSpriteFromResources("TheOtherRoles.Resources.HorseModeButtonOff.png", 75f);
            horseModeOnSprite = Helpers.loadSpriteFromResources("TheOtherRoles.Resources.HorseModeButtonOn.png", 75f);

            spriteHorseButton.sprite = horseButtonState ? horseModeOnSprite : horseModeOffSprite;

            passiveHorseButton.OnClick = new ButtonClickedEvent();

            passiveHorseButton.OnClick.AddListener((System.Action)delegate {
                horseButtonState = horseModeSelectionBehavior.OnClick();
                if (horseButtonState) {
                    if (horseModeOnSprite == null) horseModeOnSprite = Helpers.loadSpriteFromResources("TheOtherRoles.Resources.HorseModeButtonOn.png", 75f);
                    spriteHorseButton.sprite = horseModeOnSprite;
                } else {
                    if (horseModeOffSprite == null) horseModeOffSprite = Helpers.loadSpriteFromResources("TheOtherRoles.Resources.HorseModeButtonOff.png", 75f);
                    spriteHorseButton.sprite = horseModeOffSprite;
                }
                CredentialsPatch.LogoPatch.updateSprite();
                // Avoid wrong Player Particles floating around in the background
                var particles = GameObject.FindObjectOfType<PlayerParticles>();
                if (particles != null) {
                    particles.pool.ReclaimAll();
                    particles.Start();
                }
            });

            // TOR credits button
            if (bottomTemplate == null) return;
            var creditsButton = Object.Instantiate(bottomTemplate, bottomTemplate.transform.parent);
            var passiveCreditsButton = creditsButton.GetComponent<PassiveButton>();
            var spriteCreditsButton = creditsButton.GetComponent<SpriteRenderer>();

            spriteCreditsButton.sprite = Helpers.loadSpriteFromResources("TheOtherRoles.Resources.CreditsButton.png", 75f);

            passiveCreditsButton.OnClick = new ButtonClickedEvent();

            passiveCreditsButton.OnClick.AddListener((System.Action)delegate {
                // do stuff
                if (popUp != null) Object.Destroy(popUp);
                popUp = Object.Instantiate(Object.FindObjectOfType<AnnouncementPopUp>(true));
                popUp.gameObject.SetActive(true);
                popUp.Init();
                //SelectableHyperLinkHelper.DestroyGOs(popUp.selectableHyperLinks, "test");
                string creditsString = @$"<align=""center"">Contributeurs GitHub:
Gendelo
Alex2911    amsyarasyiq    MaximeGillot
Psynomit    probablyadnf    JustASysAdmin
Traduction:
omega7711    Shadhow   AKONE
Cahty_12

";
                creditsString += $@"<size=60%> Autres crédits et ressources:
OxygenFilter - pour toutes les versions allant de v2.3.0 à v2.6.1, on utilisait OxygenFilter pour un désobscurcissement automatique
Reactor - le framework utilisé pour toutes les versions avant la v2.0.0
BepInEx - Utilisé pour hook les fonctions de jeu
Essentials - Options de jeu custom par DorCoMaNdO:

Avant v1.6: On utilisait la version par défaut d'Essentials
v1.6-v1.8: On a légèrement changé la version par défaut d'Essentials. Les changements peuvent être trouvés dans la branche de notre fork.
v2.0.0 et après later: Comme on n'utilise plus Reactor, on utilise notre propre implémentation, inspiré de celle de DorCoMaNdO
Jackal and Sidekick - Idée originale du Jackal et du Sidekick vanant de Dhalucard
Among-Us-Love-Couple-Mod - Idée des rôles Lovers venant de Woodi-dev
Jester - Idée du rôle Jester venant de Maartii
ExtraRolesAmongUs - Idée des rôles Engineer et Medic venant de NotHunter101. De plus, certains extraits de code issus de l'implémentation ont été utilisés.
Among-Us-Sheriff-Mod - Idée du rôle Sheriff venant de Woodi-dev
TooManyRolesMods - Idée des rôles Detective et Time Master venant de Hardel-DW. De plus, certains extraits de code issus de l'implémentation ont été utilisés.
TownOfUs - Idée des rôles Swapper, Shifter, Arsonist et similaire au Mayor venant de Slushiegoose
Ottomated - Idée des rôles Morphling, Snitch et Camouflager venant de Ottomated
Crowded-Mod - Notre implémentation pour les lobby de 10+ joueurs est inspiré de celle de venant de la Crowded Mod Team
Goose-Goose-Duck - Idée pour le rôle Vulture venant de Slushygoose</size>";
                creditsString += "</align>";
                popUp.AnnounceTextMeshPro.text = creditsString;
                __instance.StartCoroutine(Effects.Lerp(0.01f, new Action<float>((p) => {
                    if (p == 1) {
                        var titleText = GameObject.Find("Title_Text").GetComponent<TMPro.TextMeshPro>();
                        if (titleText != null) titleText.text = "Crédits and Contributeurs";
                    }
                })));
            });
            
        }

        public static void Postfix(MainMenuManager __instance) {
            __instance.StartCoroutine(Effects.Lerp(0.01f, new Action<float>((p) => {
                if (p == 1) {
                    bottomTemplate = GameObject.Find("InventoryButton");
                    foreach (Transform tf in bottomTemplate.transform.parent.GetComponentsInChildren<Transform>()) {
                        tf.localPosition = new Vector2(tf.localPosition.x * 0.8f, tf.localPosition.y);
                    }
                }
            })));

        }
    }

    [HarmonyPatch(typeof(AnnouncementPopUp), nameof(AnnouncementPopUp.UpdateAnnounceText))]
    public static class Announcement
    {
        public static ModUpdateBehaviour.UpdateData updateData = null;
        public static bool Prefix(AnnouncementPopUp __instance)
        {
            if (ModUpdateBehaviour.showPopUp || updateData == null) return true;

            var text = __instance.AnnounceTextMeshPro;            
            text.text = $"<size=150%><color=#FC0303>THE OTHER ROLES FR</color> {(updateData.Tag)}\n{(updateData.Content)}";

            return false;
        }
    }
}