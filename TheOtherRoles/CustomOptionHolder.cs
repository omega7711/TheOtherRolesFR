using Il2CppSystem.Linq;
using System.Collections.Generic;
using UnityEngine;
using static TheOtherRoles.TheOtherRoles;
using Types = TheOtherRoles.CustomOption.CustomOptionType;

namespace TheOtherRoles {
    public class CustomOptionHolder {
        public static string[] rates = new string[]{"0%", "10%", "20%", "30%", "40%", "50%", "60%", "70%", "80%", "90%", "100%"};
        public static string[] ratesModifier = new string[]{"1", "2", "3"};
        public static string[] presets = new string[]{"Preset 1", "Preset 2", "Preset 3", "Preset 4", "Preset 5"};

        public static CustomOption presetSelection;
        public static CustomOption activateRoles;
        public static CustomOption crewmateRolesCountMin;
        public static CustomOption crewmateRolesCountMax;
        public static CustomOption neutralRolesCountMin;
        public static CustomOption neutralRolesCountMax;
        public static CustomOption impostorRolesCountMin;
        public static CustomOption impostorRolesCountMax;
        public static CustomOption modifiersCountMin;
        public static CustomOption modifiersCountMax;

        public static CustomOption mafiaSpawnRate;
        public static CustomOption janitorCooldown;

        public static CustomOption morphlingSpawnRate;
        public static CustomOption morphlingCooldown;
        public static CustomOption morphlingDuration;

        public static CustomOption camouflagerSpawnRate;
        public static CustomOption camouflagerCooldown;
        public static CustomOption camouflagerDuration;

        public static CustomOption vampireSpawnRate;
        public static CustomOption vampireKillDelay;
        public static CustomOption vampireCooldown;
        public static CustomOption vampireCanKillNearGarlics;

        public static CustomOption eraserSpawnRate;
        public static CustomOption eraserCooldown;
        public static CustomOption eraserCanEraseAnyone;
        public static CustomOption guesserSpawnRate;
        public static CustomOption guesserIsImpGuesserRate;
        public static CustomOption guesserNumberOfShots;
        public static CustomOption guesserHasMultipleShotsPerMeeting;
        public static CustomOption guesserShowInfoInGhostChat;
        public static CustomOption guesserKillsThroughShield;
        public static CustomOption guesserEvilCanKillSpy;
        public static CustomOption guesserSpawnBothRate;
        public static CustomOption guesserCantGuessSnitchIfTaksDone;

        public static CustomOption jesterSpawnRate;
        public static CustomOption jesterCanCallEmergency;
        public static CustomOption jesterHasImpostorVision;

        public static CustomOption arsonistSpawnRate;
        public static CustomOption arsonistCooldown;
        public static CustomOption arsonistDuration;

        public static CustomOption jackalSpawnRate;
        public static CustomOption jackalKillCooldown;
        public static CustomOption jackalCreateSidekickCooldown;
        public static CustomOption jackalCanUseVents;
        public static CustomOption jackalCanCreateSidekick;
        public static CustomOption sidekickPromotesToJackal;
        public static CustomOption sidekickCanKill;
        public static CustomOption sidekickCanUseVents;
        public static CustomOption jackalPromotedFromSidekickCanCreateSidekick;
        public static CustomOption jackalCanCreateSidekickFromImpostor;
        public static CustomOption jackalAndSidekickHaveImpostorVision;

        public static CustomOption bountyHunterSpawnRate;
        public static CustomOption bountyHunterBountyDuration;
        public static CustomOption bountyHunterReducedCooldown;
        public static CustomOption bountyHunterPunishmentTime;
        public static CustomOption bountyHunterShowArrow;
        public static CustomOption bountyHunterArrowUpdateIntervall;

        public static CustomOption witchSpawnRate;
        public static CustomOption witchCooldown;
        public static CustomOption witchAdditionalCooldown;
        public static CustomOption witchCanSpellAnyone;
        public static CustomOption witchSpellCastingDuration;
        public static CustomOption witchTriggerBothCooldowns;
        public static CustomOption witchVoteSavesTargets;

        public static CustomOption ninjaSpawnRate;
        public static CustomOption ninjaCooldown;
        public static CustomOption ninjaKnowsTargetLocation;
        public static CustomOption ninjaTraceTime;
        public static CustomOption ninjaTraceColorTime;
        public static CustomOption ninjaInvisibleDuration;

        public static CustomOption shifterSpawnRate;
        public static CustomOption shifterShiftsModifiers;

        public static CustomOption mayorSpawnRate;
        public static CustomOption mayorCanSeeVoteColors;
        public static CustomOption mayorTasksNeededToSeeVoteColors;
        public static CustomOption mayorMeetingButton;
        public static CustomOption mayorMaxRemoteMeetings;

        public static CustomOption portalmakerSpawnRate;
        public static CustomOption portalmakerCooldown;
        public static CustomOption portalmakerUsePortalCooldown;
        public static CustomOption portalmakerLogOnlyColorType;
        public static CustomOption portalmakerLogHasTime;

        public static CustomOption engineerSpawnRate;
        public static CustomOption engineerNumberOfFixes;
        public static CustomOption engineerHighlightForImpostors;
        public static CustomOption engineerHighlightForTeamJackal;

        public static CustomOption sheriffSpawnRate;
        public static CustomOption sheriffCooldown;
        public static CustomOption sheriffCanKillNeutrals;
        public static CustomOption deputySpawnRate;

        public static CustomOption deputyNumberOfHandcuffs;
        public static CustomOption deputyHandcuffCooldown;
        public static CustomOption deputyGetsPromoted;
        public static CustomOption deputyKeepsHandcuffs;
        public static CustomOption deputyHandcuffDuration;
        public static CustomOption deputyKnowsSheriff;

        public static CustomOption lighterSpawnRate;
        public static CustomOption lighterModeLightsOnVision;
        public static CustomOption lighterModeLightsOffVision;
        public static CustomOption lighterCooldown;
        public static CustomOption lighterDuration;

        public static CustomOption detectiveSpawnRate;
        public static CustomOption detectiveAnonymousFootprints;
        public static CustomOption detectiveFootprintIntervall;
        public static CustomOption detectiveFootprintDuration;
        public static CustomOption detectiveReportNameDuration;
        public static CustomOption detectiveReportColorDuration;

        public static CustomOption timeMasterSpawnRate;
        public static CustomOption timeMasterCooldown;
        public static CustomOption timeMasterRewindTime;
        public static CustomOption timeMasterShieldDuration;

        public static CustomOption medicSpawnRate;
        public static CustomOption medicShowShielded;
        public static CustomOption medicShowAttemptToShielded;
        public static CustomOption medicSetOrShowShieldAfterMeeting;
        public static CustomOption medicShowAttemptToMedic;
        public static CustomOption medicSetShieldAfterMeeting;

        public static CustomOption swapperSpawnRate;
        public static CustomOption swapperCanCallEmergency;
        public static CustomOption swapperCanOnlySwapOthers;
        public static CustomOption swapperSwapsNumber;
        public static CustomOption swapperRechargeTasksNumber;

        public static CustomOption seerSpawnRate;
        public static CustomOption seerMode;
        public static CustomOption seerSoulDuration;
        public static CustomOption seerLimitSoulDuration;

        public static CustomOption hackerSpawnRate;
        public static CustomOption hackerCooldown;
        public static CustomOption hackerHackeringDuration;
        public static CustomOption hackerOnlyColorType;
        public static CustomOption hackerToolsNumber;
        public static CustomOption hackerRechargeTasksNumber;
        public static CustomOption hackerNoMove;

        public static CustomOption trackerSpawnRate;
        public static CustomOption trackerUpdateIntervall;
        public static CustomOption trackerResetTargetAfterMeeting;
        public static CustomOption trackerCanTrackCorpses;
        public static CustomOption trackerCorpsesTrackingCooldown;
        public static CustomOption trackerCorpsesTrackingDuration;

        public static CustomOption snitchSpawnRate;
        public static CustomOption snitchLeftTasksForReveal;
        public static CustomOption snitchIncludeTeamJackal;
        public static CustomOption snitchTeamJackalUseDifferentArrowColor;

        public static CustomOption spySpawnRate;
        public static CustomOption spyCanDieToSheriff;
        public static CustomOption spyImpostorsCanKillAnyone;
        public static CustomOption spyCanEnterVents;
        public static CustomOption spyHasImpostorVision;

        public static CustomOption tricksterSpawnRate;
        public static CustomOption tricksterPlaceBoxCooldown;
        public static CustomOption tricksterLightsOutCooldown;
        public static CustomOption tricksterLightsOutDuration;

        public static CustomOption cleanerSpawnRate;
        public static CustomOption cleanerCooldown;
        
        public static CustomOption warlockSpawnRate;
        public static CustomOption warlockCooldown;
        public static CustomOption warlockRootTime;

        public static CustomOption securityGuardSpawnRate;
        public static CustomOption securityGuardCooldown;
        public static CustomOption securityGuardTotalScrews;
        public static CustomOption securityGuardCamPrice;
        public static CustomOption securityGuardVentPrice;
        public static CustomOption securityGuardCamDuration;
        public static CustomOption securityGuardCamMaxCharges;
        public static CustomOption securityGuardCamRechargeTasksNumber;
        public static CustomOption securityGuardNoMove;

        public static CustomOption vultureSpawnRate;
        public static CustomOption vultureCooldown;
        public static CustomOption vultureNumberToWin;
        public static CustomOption vultureCanUseVents;
        public static CustomOption vultureShowArrows;

        public static CustomOption mediumSpawnRate;
        public static CustomOption mediumCooldown;
        public static CustomOption mediumDuration;
        public static CustomOption mediumOneTimeUse;

        public static CustomOption lawyerSpawnRate;
        public static CustomOption lawyerTargetCanBeJester;
        public static CustomOption lawyerVision;
        public static CustomOption lawyerKnowsRole;
        public static CustomOption pursuerCooldown;
        public static CustomOption pursuerBlanksNumber;

        public static CustomOption modifiersAreHidden;

        public static CustomOption modifierBait;
        public static CustomOption modifierBaitQuantity;
        public static CustomOption modifierBaitReportDelayMin;
        public static CustomOption modifierBaitReportDelayMax;
        public static CustomOption modifierBaitShowKillFlash;

        public static CustomOption modifierLover;
        public static CustomOption modifierLoverImpLoverRate;
        public static CustomOption modifierLoverBothDie;
        public static CustomOption modifierLoverEnableChat;

        public static CustomOption modifierBloody;
        public static CustomOption modifierBloodyQuantity;
        public static CustomOption modifierBloodyDuration;

        public static CustomOption modifierAntiTeleport;
        public static CustomOption modifierAntiTeleportQuantity;

        public static CustomOption modifierTieBreaker;

        public static CustomOption modifierSunglasses;
        public static CustomOption modifierSunglassesQuantity;
        public static CustomOption modifierSunglassesVision;
        
        public static CustomOption modifierMini;
        public static CustomOption modifierMiniGrowingUpDuration;

        public static CustomOption modifierVip;
        public static CustomOption modifierVipQuantity;
        public static CustomOption modifierVipShowColor;

        public static CustomOption modifierInvert;
        public static CustomOption modifierInvertQuantity;
        public static CustomOption modifierInvertDuration;
        
        public static CustomOption maxNumberOfMeetings;
        public static CustomOption blockSkippingInEmergencyMeetings;
        public static CustomOption noVoteIsSelfVote;
        public static CustomOption hidePlayerNames;
        public static CustomOption allowParallelMedBayScans;
        public static CustomOption shieldFirstKill;

        public static CustomOption dynamicMap;
        public static CustomOption dynamicMapEnableSkeld;
        public static CustomOption dynamicMapEnableMira;
        public static CustomOption dynamicMapEnablePolus;
        public static CustomOption dynamicMapEnableAirShip;
        public static CustomOption dynamicMapEnableSubmerged;


        internal static Dictionary<byte, byte[]> blockedRolePairings = new Dictionary<byte, byte[]>();

        public static string cs(Color c, string s) {
            return string.Format("<color=#{0:X2}{1:X2}{2:X2}{3:X2}>{4}</color>", ToByte(c.r), ToByte(c.g), ToByte(c.b), ToByte(c.a), s);
        }
 
        private static byte ToByte(float f) {
            f = Mathf.Clamp01(f);
            return (byte)(f * 255);
        }

        public static void Load() {
            
            
            // Role Options
            presetSelection = CustomOption.Create(0, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "Preset"), presets, null, true);
            activateRoles = CustomOption.Create(1, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "Activer les rôles du mod et bloquer les rôles Vanilla"), true, null, true);

            // Using new id's for the options to not break compatibilty with older versions
            crewmateRolesCountMin = CustomOption.Create(300, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "Nombre Min. de rôles Crewmate"), 15f, 0f, 15f, 1f, null, true);
            crewmateRolesCountMax = CustomOption.Create(301, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "Nombre Max. de rôles Crewmate"), 15f, 0f, 15f, 1f);
            neutralRolesCountMin = CustomOption.Create(302, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "Nombre Min. de rôles Neutres"), 15f, 0f, 15f, 1f);
            neutralRolesCountMax = CustomOption.Create(303, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "Nombre Max. de rôles Neutres"), 15f, 0f, 15f, 1f);
            impostorRolesCountMin = CustomOption.Create(304, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "Nombre Min. de rôles Imposteurs"), 15f, 0f, 3f, 1f);
            impostorRolesCountMax = CustomOption.Create(305, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "Nombre Max. de rôles Imposteurs"), 15f, 0f, 3f, 1f);
            modifiersCountMin = CustomOption.Create(306, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "Nombre Min. de Modificateurs"), 15f, 0f, 15f, 1f);
            modifiersCountMax = CustomOption.Create(307, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "Nombre Max. de Modificateurs"), 15f, 0f, 15f, 1f);

            mafiaSpawnRate = CustomOption.Create(10, Types.Impostor, cs(Janitor.color, "Mafia"), rates, null, true);
            janitorCooldown = CustomOption.Create(11, Types.Impostor, "Cooldown du Concierge", 30f, 10f, 60f, 2.5f, mafiaSpawnRate);

            morphlingSpawnRate = CustomOption.Create(20, Types.Impostor, cs(Morphling.color, "Morphling"), rates, null, true);
            morphlingCooldown = CustomOption.Create(21, Types.Impostor, "Cooldown Morphling", 30f, 10f, 60f, 2.5f, morphlingSpawnRate);
            morphlingDuration = CustomOption.Create(22, Types.Impostor, "Durée de Métamorphose", 10f, 1f, 20f, 0.5f, morphlingSpawnRate);

            camouflagerSpawnRate = CustomOption.Create(30, Types.Impostor, cs(Camouflager.color, "Camoufleur"), rates, null, true);
            camouflagerCooldown = CustomOption.Create(31, Types.Impostor, "Cooldown du Camoufleur", 30f, 10f, 60f, 2.5f, camouflagerSpawnRate);
            camouflagerDuration = CustomOption.Create(32, Types.Impostor, "Durée de Camo", 10f, 1f, 20f, 0.5f, camouflagerSpawnRate);

            vampireSpawnRate = CustomOption.Create(40, Types.Impostor, cs(Vampire.color, "Vampire"), rates, null, true);
            vampireKillDelay = CustomOption.Create(41, Types.Impostor, "Délai de Kill du Vampire", 10f, 1f, 20f, 1f, vampireSpawnRate);
            vampireCooldown = CustomOption.Create(42, Types.Impostor, "Cooldown du Vampire", 30f, 10f, 60f, 2.5f, vampireSpawnRate);
            vampireCanKillNearGarlics = CustomOption.Create(43, Types.Impostor, "Vampire Peut Tuer Proche des Oignons", true, vampireSpawnRate);

            eraserSpawnRate = CustomOption.Create(230, Types.Impostor, cs(Eraser.color, "Effaceur"), rates, null, true);
            eraserCooldown = CustomOption.Create(231, Types.Impostor, "Cooldown de l'Effaceur", 30f, 10f, 120f, 5f, eraserSpawnRate);
            eraserCanEraseAnyone = CustomOption.Create(232, Types.Impostor, "L'Effaceur Peut Effacer n'Importe Qui", false, eraserSpawnRate);

            tricksterSpawnRate = CustomOption.Create(250, Types.Impostor, cs(Trickster.color, "Filou"), rates, null, true);
            tricksterPlaceBoxCooldown = CustomOption.Create(251, Types.Impostor, "Cooldown des boîtes du Filou", 10f, 2.5f, 30f, 2.5f, tricksterSpawnRate);
            tricksterLightsOutCooldown = CustomOption.Create(252, Types.Impostor, "Cooldown de l'abilité Lights Out du Filou", 30f, 10f, 60f, 5f, tricksterSpawnRate);
            tricksterLightsOutDuration = CustomOption.Create(253, Types.Impostor, "Durée de l'abilité Lights Out", 15f, 5f, 60f, 2.5f, tricksterSpawnRate);

            cleanerSpawnRate = CustomOption.Create(260, Types.Impostor, cs(Cleaner.color, "Nettoyeur"), rates, null, true);
            cleanerCooldown = CustomOption.Create(261, Types.Impostor, "Cooldown du Nettoyeur", 30f, 10f, 60f, 2.5f, cleanerSpawnRate);

            warlockSpawnRate = CustomOption.Create(270, Types.Impostor, cs(Cleaner.color, "Sorcier"), rates, null, true);
            warlockCooldown = CustomOption.Create(271, Types.Impostor, "Cooldown du Sorcier", 30f, 10f, 60f, 2.5f, warlockSpawnRate);
            warlockRootTime = CustomOption.Create(272, Types.Impostor, "Temps Enraciné", 5f, 0f, 15f, 1f, warlockSpawnRate);

            bountyHunterSpawnRate = CustomOption.Create(320, Types.Impostor, cs(BountyHunter.color, "Mandalorian"), rates, null, true);
            bountyHunterBountyDuration = CustomOption.Create(321, Types.Impostor, "Durée Après laquelle la prime change",  60f, 10f, 180f, 10f, bountyHunterSpawnRate);
            bountyHunterReducedCooldown = CustomOption.Create(322, Types.Impostor, "Cooldown Après avoir Tué la Prime", 2.5f, 0f, 30f, 2.5f, bountyHunterSpawnRate);
            bountyHunterPunishmentTime = CustomOption.Create(323, Types.Impostor, "Cooldown Additionnel Après avoir Tué les Autres", 20f, 0f, 60f, 2.5f, bountyHunterSpawnRate);
            bountyHunterShowArrow = CustomOption.Create(324, Types.Impostor, "Montrer un Flèche Pointant vers la Prime", true, bountyHunterSpawnRate);
            bountyHunterArrowUpdateIntervall = CustomOption.Create(325, Types.Impostor, "Intervalle de Mise à Jour de la Flèche", 15f, 2.5f, 60f, 2.5f, bountyHunterShowArrow);

            witchSpawnRate = CustomOption.Create(370, Types.Impostor, cs(Witch.color, "Sorcière"), rates, null, true);
            witchCooldown = CustomOption.Create(371, Types.Impostor, "Cooldown entre les sorts", 30f, 10f, 120f, 5f, witchSpawnRate);
            witchAdditionalCooldown = CustomOption.Create(372, Types.Impostor, "Cooldown Additionnel", 10f, 0f, 60f, 5f, witchSpawnRate);
            witchCanSpellAnyone = CustomOption.Create(373, Types.Impostor, "les Sorcières peuvent ensorceller tout le monde", false, witchSpawnRate);
            witchSpellCastingDuration = CustomOption.Create(374, Types.Impostor, "Durée d'incantation", 1f, 0f, 10f, 1f, witchSpawnRate);
            witchTriggerBothCooldowns = CustomOption.Create(375, Types.Impostor, "Cooldown partagés", true, witchSpawnRate);
            witchVoteSavesTargets = CustomOption.Create(376, Types.Impostor, "Voter les Sorcière Sauve Toutes les Cibles", true, witchSpawnRate);

            ninjaSpawnRate = CustomOption.Create(380, Types.Impostor, cs(Ninja.color, "Ninja"), rates, null, true);
            ninjaCooldown = CustomOption.Create(381, Types.Impostor, "Cooldown pour Marquer", 30f, 10f, 120f, 5f, ninjaSpawnRate);
            ninjaKnowsTargetLocation = CustomOption.Create(382, Types.Impostor, "Le Ninja Connaît la Position de la Cible", true, ninjaSpawnRate);
            ninjaTraceTime = CustomOption.Create(383, Types.Impostor, "Durée de la Trace", 5f, 1f, 20f, 0.5f, ninjaSpawnRate);
            ninjaTraceColorTime = CustomOption.Create(384, Types.Impostor, "Temps Avant que la Couleur de la Trace Change", 2f, 0f, 20f, 0.5f, ninjaSpawnRate);
            ninjaInvisibleDuration = CustomOption.Create(385, Types.Impostor, "Temps où le Ninja est Invisible", 3f, 0f, 20f, 1f, ninjaSpawnRate);

            guesserSpawnRate = CustomOption.Create(310, Types.Neutral, cs(Guesser.color, "Devin"), rates, null, true);
            guesserIsImpGuesserRate = CustomOption.Create(311, Types.Neutral, "Chance Que le Devin Soit un Imposteur", rates, guesserSpawnRate);
            guesserNumberOfShots = CustomOption.Create(312, Types.Neutral, "Nombre de Tirs par Partie", 2f, 1f, 15f, 1f, guesserSpawnRate);
            guesserHasMultipleShotsPerMeeting = CustomOption.Create(313, Types.Neutral, "Le Devin Peut Tirer Plusieurs Fois par Meeting", false, guesserSpawnRate);
            guesserShowInfoInGhostChat = CustomOption.Create(314, Types.Neutral, "Les Suppositioons sont Visible dans le Chat Fantômes", true, guesserSpawnRate);
            guesserKillsThroughShield  = CustomOption.Create(315, Types.Neutral, "Les Suppositions ignorent le Bouclier Médical", true, guesserSpawnRate);
            guesserEvilCanKillSpy  = CustomOption.Create(316, Types.Neutral, "Le Devin Maléfique Peut Deviner l'Espion", true, guesserSpawnRate);
            guesserSpawnBothRate = CustomOption.Create(317, Types.Neutral, "Taux d'Apparition des Deux Devins", rates, guesserSpawnRate);
            guesserCantGuessSnitchIfTaksDone = CustomOption.Create(318, Types.Neutral, "Le Devin ne Peut pas Deviner le Mouchard Quand il a Fini ses Tâches", true, guesserSpawnRate);

            jesterSpawnRate = CustomOption.Create(60, Types.Neutral, cs(Jester.color, "Bouffon"), rates, null, true);
            jesterCanCallEmergency = CustomOption.Create(61, Types.Neutral, "Le Bouffon Peut Faire des de Meetings d'Urgence", true, jesterSpawnRate);
            jesterHasImpostorVision = CustomOption.Create(62, Types.Neutral, "Le Bouffon a la Vision des Imposteurs", false, jesterSpawnRate);

            arsonistSpawnRate = CustomOption.Create(290, Types.Neutral, cs(Arsonist.color, "Incendiaire"), rates, null, true);
            arsonistCooldown = CustomOption.Create(291, Types.Neutral, "Cooldown de L'Incendiaire", 12.5f, 2.5f, 60f, 2.5f, arsonistSpawnRate);
            arsonistDuration = CustomOption.Create(292, Types.Neutral, "Durée d'Arrosage de l'Incendiaire", 3f, 1f, 10f, 1f, arsonistSpawnRate);

            jackalSpawnRate = CustomOption.Create(220, Types.Neutral, cs(Jackal.color, "Chacal"), rates, null, true);
            jackalKillCooldown = CustomOption.Create(221, Types.Neutral, "Cooldown de Kill du Chacal/Acolyte", 30f, 10f, 60f, 2.5f, jackalSpawnRate);
            jackalCreateSidekickCooldown = CustomOption.Create(222, Types.Neutral, "Cooldown de Création d'Acolyte par le Chacal", 30f, 10f, 60f, 2.5f, jackalSpawnRate);
            jackalCanUseVents = CustomOption.Create(223, Types.Neutral, "Le Chacal Peut Utiliser les Vents", true, jackalSpawnRate);
            jackalCanCreateSidekick = CustomOption.Create(224, Types.Neutral, "Le Chacal Peut créer un Acolyte", false, jackalSpawnRate);
            sidekickPromotesToJackal = CustomOption.Create(225, Types.Neutral, "L'Acolyte est Promu en Chacal Lors de la Mort de son Chacal", false, jackalCanCreateSidekick);
            sidekickCanKill = CustomOption.Create(226, Types.Neutral, "L'Acolyte peut tuer", false, jackalCanCreateSidekick);
            sidekickCanUseVents = CustomOption.Create(227, Types.Neutral, "L'Acolyte peut utiliser les vents", true, jackalCanCreateSidekick);
            jackalPromotedFromSidekickCanCreateSidekick = CustomOption.Create(228, Types.Neutral, "Les Chacals promu par un Acolyte peuvent créer un Acolyte", true, sidekickPromotesToJackal);
            jackalCanCreateSidekickFromImpostor = CustomOption.Create(229, Types.Neutral, "Les Chacals peuvent transformer un Imposteur en son Acolyte", true, jackalCanCreateSidekick);
            jackalAndSidekickHaveImpostorVision = CustomOption.Create(430, Types.Neutral, "Les Chacals et les Acolytes ont la vision des Imposteurs", false, jackalSpawnRate);

            vultureSpawnRate = CustomOption.Create(340, Types.Neutral, cs(Vulture.color, "Vautour"), rates, null, true);
            vultureCooldown = CustomOption.Create(341, Types.Neutral, "Cooldown du Vautour", 15f, 10f, 60f, 2.5f, vultureSpawnRate);
            vultureNumberToWin = CustomOption.Create(342, Types.Neutral, "Nombre de Corps Mangés Nécessaire", 4f, 1f, 10f, 1f, vultureSpawnRate);
            vultureCanUseVents = CustomOption.Create(343, Types.Neutral, "Le Vautour Peut Utiliser les Vents", true, vultureSpawnRate);
            vultureShowArrows = CustomOption.Create(344, Types.Neutral, "Montrer les Flèches Pointant Vers les Corps", true, vultureSpawnRate);

            lawyerSpawnRate = CustomOption.Create(350, Types.Neutral, cs(Lawyer.color, "Avocat"), rates, null, true);
            lawyerTargetCanBeJester = CustomOption.Create(351, Types.Neutral, "Le Client de l'Avocat peut être le Bouffon", false, lawyerSpawnRate);
            lawyerVision = CustomOption.Create(354, Types.Neutral, "Vision de l'Avocat", 1f, 0.25f, 3f, 0.25f, lawyerSpawnRate);
            lawyerKnowsRole = CustomOption.Create(355, Types.Neutral, "L'Avocat connaît le rôle de son Client", false, lawyerSpawnRate);
            pursuerCooldown = CustomOption.Create(356, Types.Neutral, "Cooldown de remplissage à blanc", 30f, 5f, 60f, 2.5f, lawyerSpawnRate);
            pursuerBlanksNumber = CustomOption.Create(357, Types.Neutral, "Nombre de balles à blanc", 5f, 1f, 20f, 1f, lawyerSpawnRate);

            shifterSpawnRate = CustomOption.Create(70, Types.Crewmate, cs(Shifter.color, "Shifter"), rates, null, true);
            shifterShiftsModifiers = CustomOption.Create(71, Types.Crewmate, "Le Shifter change les Modificateurs", false, shifterSpawnRate);

            mayorSpawnRate = CustomOption.Create(80, Types.Crewmate, cs(Mayor.color, "Maire"), rates, null, true);
            mayorCanSeeVoteColors = CustomOption.Create(81, Types.Crewmate, "Le Maire Peut Voir la Couleur des Votes", false, mayorSpawnRate);
            mayorTasksNeededToSeeVoteColors = CustomOption.Create(82, Types.Crewmate, "Nombre de Tâches Nécessaire Pour Voir la Couleur des Votes", 5f, 0f, 20f, 1f, mayorCanSeeVoteColors);
            mayorMeetingButton = CustomOption.Create(83, Types.Crewmate, "Bouton d'Urgence Mobile", true, mayorSpawnRate);
            mayorMaxRemoteMeetings = CustomOption.Create(84, Types.Crewmate, "Nombre de Meetings à Distance", 1f, 1f, 5f, 1f, mayorMeetingButton);

            engineerSpawnRate = CustomOption.Create(90, Types.Crewmate, cs(Engineer.color, "Ingénieur"), rates, null, true);
            engineerNumberOfFixes = CustomOption.Create(91, Types.Crewmate, "Nombre de Réparations de Sabotage", 1f, 1f, 3f, 1f, engineerSpawnRate);
            engineerHighlightForImpostors = CustomOption.Create(92, Types.Crewmate, "Mettre les Vents en Surbrillance pour les Imposteurs", true, engineerSpawnRate);
            engineerHighlightForTeamJackal = CustomOption.Create(93, Types.Crewmate, "Mettre les Vents en Surbrillance pour les Chacals et les Acolytes", true, engineerSpawnRate);

            sheriffSpawnRate = CustomOption.Create(100, Types.Crewmate, cs(Sheriff.color, "Shérif"), rates, null, true);
            sheriffCooldown = CustomOption.Create(101, Types.Crewmate, "Cooldown du Shérif", 30f, 10f, 60f, 2.5f, sheriffSpawnRate);
            sheriffCanKillNeutrals = CustomOption.Create(102, Types.Crewmate, "Le Shérif Peut Tuer les Neutres", false, sheriffSpawnRate);
            deputySpawnRate = CustomOption.Create(103, Types.Crewmate, "Le Shérif a un Adjoint", rates, sheriffSpawnRate);
            deputyNumberOfHandcuffs = CustomOption.Create(104, Types.Crewmate, "Nombre de Menottes utilisables", 3f, 1f, 10f, 1f, deputySpawnRate);
            deputyHandcuffCooldown = CustomOption.Create(105, Types.Crewmate, "Cooldown de Menottage", 30f, 10f, 60f, 2.5f, deputySpawnRate);
            deputyHandcuffDuration = CustomOption.Create(106, Types.Crewmate, "Durée du menottage", 15f, 5f, 60f, 2.5f, deputySpawnRate);
            deputyKnowsSheriff = CustomOption.Create(107, Types.Crewmate, "Le Shérif et L'Adjoint Connaissent le rôle de l'autre", true, deputySpawnRate);
            deputyGetsPromoted = CustomOption.Create(108, Types.Crewmate, "L'adjoint est Promu Shérif", new string[] { "Off", "On (Immédiatement)", "On (Après un Meeting)" }, deputySpawnRate);
            deputyKeepsHandcuffs = CustomOption.Create(109, Types.Crewmate, "L'adjoint Garde ses Menottes quand il est Promu", true, deputyGetsPromoted);

            lighterSpawnRate = CustomOption.Create(110, Types.Crewmate, cs(Lighter.color, "Eclaireur"), rates, null, true);
            lighterModeLightsOnVision = CustomOption.Create(111, Types.Crewmate, "Vision du Joueur Quand Briquet On & Lumières On", 2f, 0.25f, 5f, 0.25f, lighterSpawnRate);
            lighterModeLightsOffVision = CustomOption.Create(112, Types.Crewmate, "Vision du Joueur Quand Briquet On & Lumières Off", 0.75f, 0.25f, 5f, 0.25f, lighterSpawnRate);
            lighterCooldown = CustomOption.Create(113, Types.Crewmate, "Cooldown du Briquet", 30f, 5f, 120f, 5f, lighterSpawnRate);
            lighterDuration = CustomOption.Create(114, Types.Crewmate, "Durée du Briquet", 5f, 2.5f, 60f, 2.5f, lighterSpawnRate);

            detectiveSpawnRate = CustomOption.Create(120, Types.Crewmate, cs(Detective.color, "Détective"), rates, null, true);
            detectiveAnonymousFootprints = CustomOption.Create(121, Types.Crewmate, "Empreintes Anonymes", false, detectiveSpawnRate); 
            detectiveFootprintIntervall = CustomOption.Create(122, Types.Crewmate, "Intervalle des Empreintes", 0.5f, 0.25f, 10f, 0.25f, detectiveSpawnRate);
            detectiveFootprintDuration = CustomOption.Create(123, Types.Crewmate, "Durée des Empreintes", 5f, 0.25f, 10f, 0.25f, detectiveSpawnRate);
            detectiveReportNameDuration = CustomOption.Create(124, Types.Crewmate, "Temps Où Les Reports de Détective Auront le Nom", 0, 0, 60, 2.5f, detectiveSpawnRate);
            detectiveReportColorDuration = CustomOption.Create(125, Types.Crewmate, "Temps Où Les Reports de Détective Auront le Type de Couleur", 20, 0, 120, 2.5f, detectiveSpawnRate);

            timeMasterSpawnRate = CustomOption.Create(130, Types.Crewmate, cs(TimeMaster.color, "Maître du Temps"), rates, null, true);
            timeMasterCooldown = CustomOption.Create(131, Types.Crewmate, "Cooldown du Maître du Temps", 30f, 10f, 120f, 2.5f, timeMasterSpawnRate);
            timeMasterRewindTime = CustomOption.Create(132, Types.Crewmate, "Durée de Rembobinage", 3f, 1f, 10f, 1f, timeMasterSpawnRate);
            timeMasterShieldDuration = CustomOption.Create(133, Types.Crewmate, "Durée du Bouclier du Maître du Temps", 3f, 1f, 20f, 1f, timeMasterSpawnRate);

            medicSpawnRate = CustomOption.Create(140, Types.Crewmate, cs(Medic.color, "Médecin"), rates, null, true);
            medicShowShielded = CustomOption.Create(143, Types.Crewmate, "Afficher les Joueurs Protégés", new string[] {"Tout le monde", "Protégés + Médecin", "Médecin"}, medicSpawnRate);
            medicShowAttemptToShielded = CustomOption.Create(144, Types.Crewmate, "Les Joueurs Proyégés Voient les Tentatives de Meurtres", false, medicSpawnRate);
            medicSetOrShowShieldAfterMeeting = CustomOption.Create(145, Types.Crewmate, "Le Bouclier Sera Actif", new string[] { "Instantanément", "Instantanément, Visible\naprès un Meeting", "Après un Meeting" }, medicSpawnRate);

            medicShowAttemptToMedic = CustomOption.Create(146, Types.Crewmate, "Le Médecin Voit les Tentatives de Meurtre sur un Joueur Protégé", false, medicSpawnRate);

            swapperSpawnRate = CustomOption.Create(150, Types.Crewmate, cs(Swapper.color, "Swapeur"), rates, null, true);
            swapperCanCallEmergency = CustomOption.Create(151, Types.Crewmate, "Le Swapeur Peut Faire des Meetings d'Urgenge", false, swapperSpawnRate);
            swapperCanOnlySwapOthers = CustomOption.Create(152, Types.Crewmate, "Le Swapeur peux seulement échanger les autres", false, swapperSpawnRate);

            swapperSwapsNumber = CustomOption.Create(153, Types.Crewmate, "Nombre d'échanges initial", 1f, 0f, 5f, 1f, swapperSpawnRate);
            swapperRechargeTasksNumber = CustomOption.Create(154, Types.Crewmate, "Nombre de Tâches Requis Pour Recharger", 2f, 1f, 10f, 1f, swapperSpawnRate);


            seerSpawnRate = CustomOption.Create(160, Types.Crewmate, cs(Seer.color, "Voyant"), rates, null, true);
            seerMode = CustomOption.Create(161, Types.Crewmate, "Mode du Voyant", new string[]{ "Voir les flashs + les âmes", "Voir les flashs de mort", "Voir les âmes" }, seerSpawnRate);
            seerLimitSoulDuration = CustomOption.Create(163, Types.Crewmate, "Durée de la vue des Âmes", false, seerSpawnRate);
            seerSoulDuration = CustomOption.Create(162, Types.Crewmate, "Durée de vue des Âme", 15f, 0f, 120f, 5f, seerLimitSoulDuration);
        
            hackerSpawnRate = CustomOption.Create(170, Types.Crewmate, cs(Hacker.color, "Hacker"), rates, null, true);
            hackerCooldown = CustomOption.Create(171, Types.Crewmate, "Cooldown du Hacker", 30f, 5f, 60f, 5f, hackerSpawnRate);
            hackerHackeringDuration = CustomOption.Create(172, Types.Crewmate, "Durée du Hack", 10f, 2.5f, 60f, 2.5f, hackerSpawnRate);
            hackerOnlyColorType = CustomOption.Create(173, Types.Crewmate, "Le Hacker Voit Uniquement le Type de Couleur", false, hackerSpawnRate);
            hackerToolsNumber = CustomOption.Create(174, Types.Crewmate, "Nombre Max de Charges au Gadget Mobile", 5f, 1f, 30f, 1f, hackerSpawnRate);
            hackerRechargeTasksNumber = CustomOption.Create(175, Types.Crewmate, "Nombre de Tâches Nécessaire pour Recharger", 2f, 1f, 5f, 1f, hackerSpawnRate);
            hackerNoMove = CustomOption.Create(176, Types.Crewmate, "Durée où il ne Peut pas Bouger Pendant le Hacking", true, hackerSpawnRate);

            trackerSpawnRate = CustomOption.Create(200, Types.Crewmate, cs(Tracker.color, "Pisteur"), rates, null, true);
            trackerUpdateIntervall = CustomOption.Create(201, Types.Crewmate, "Interval de Mise à Jour du Pisteur", 5f, 1f, 30f, 1f, trackerSpawnRate);
            trackerResetTargetAfterMeeting = CustomOption.Create(202, Types.Crewmate, "Le Pisteur Réinitialise la Cible Après un Meeting", false, trackerSpawnRate);
            trackerCanTrackCorpses = CustomOption.Create(203, Types.Crewmate, "Le Pisteur Peut Pister les Corps", true, trackerSpawnRate);
            trackerCorpsesTrackingCooldown = CustomOption.Create(204, Types.Crewmate, "Cooldown Pour Pister les Corps", 30f, 5f, 120f, 5f, trackerCanTrackCorpses);
            trackerCorpsesTrackingDuration = CustomOption.Create(205, Types.Crewmate, "Durée De Pistage des Corps", 5f, 2.5f, 30f, 2.5f, trackerCanTrackCorpses);
                           
            snitchSpawnRate = CustomOption.Create(210, Types.Crewmate, cs(Snitch.color, "Mouchard"), rates, null, true);
            snitchLeftTasksForReveal = CustomOption.Create(211, Types.Crewmate, "Compte des Tâches où le Mouchard Sera Révélé", 1f, 0f, 5f, 1f, snitchSpawnRate);
            snitchIncludeTeamJackal = CustomOption.Create(212, Types.Crewmate, "Inclus l'équipe Chacal", false, snitchSpawnRate);
            snitchTeamJackalUseDifferentArrowColor = CustomOption.Create(213, Types.Crewmate, "Utiliser Une Couleur Différente de Flèche Pour l'Équipe Chacal", true, snitchIncludeTeamJackal);

            spySpawnRate = CustomOption.Create(240, Types.Crewmate, cs(Spy.color, "Espion"), rates, null, true);
            spyCanDieToSheriff = CustomOption.Create(241, Types.Crewmate, "Le Shérif Peut Tuer l'Espion", false, spySpawnRate);
            spyImpostorsCanKillAnyone = CustomOption.Create(242, Types.Crewmate, "Les Imposteurs Peuvent Tuer Tout le Monde si il y a un Espion", true, spySpawnRate);
            spyCanEnterVents = CustomOption.Create(243, Types.Crewmate, "L'Espion Peut Entrer Dans les Vents", false, spySpawnRate);
            spyHasImpostorVision = CustomOption.Create(244, Types.Crewmate, "L'Espion a la Vision d'un Imposteur", false, spySpawnRate);

            portalmakerSpawnRate = CustomOption.Create(390, Types.Crewmate, cs(Portalmaker.color, "Dieu du Portail"), rates, null, true);
            portalmakerCooldown = CustomOption.Create(391, Types.Crewmate, "Cooldown du Dieu du Portail", 30f, 10f, 60f, 2.5f, portalmakerSpawnRate);
            portalmakerUsePortalCooldown = CustomOption.Create(392, Types.Crewmate, "Use Portal Cooldown", 30f, 10f, 60f, 2.5f, portalmakerSpawnRate);
            portalmakerLogOnlyColorType = CustomOption.Create(393, Types.Crewmate, "Les logs Dieu du Portail n'Affichent que le Type de Couleur", true, portalmakerSpawnRate);
            portalmakerLogHasTime = CustomOption.Create(394, Types.Crewmate, "Temps d'Affichage des Logs", true, portalmakerSpawnRate);

            securityGuardSpawnRate = CustomOption.Create(280, Types.Crewmate, cs(SecurityGuard.color, "Agent de Sécurité"), rates, null, true);
            securityGuardCooldown = CustomOption.Create(281, Types.Crewmate, "Cooldown de l'Agent de Sécurité", 30f, 10f, 60f, 2.5f, securityGuardSpawnRate);
            securityGuardTotalScrews = CustomOption.Create(282, Types.Crewmate, "Nombre de Vis de l'Agent de Sécurité", 7f, 1f, 15f, 1f, securityGuardSpawnRate);
            securityGuardCamPrice = CustomOption.Create(283, Types.Crewmate, "Nombre de Vis par Cam", 2f, 1f, 15f, 1f, securityGuardSpawnRate);
            securityGuardVentPrice = CustomOption.Create(284, Types.Crewmate, "Nombre de Vis par Vent", 1f, 1f, 15f, 1f, securityGuardSpawnRate);
            securityGuardCamDuration = CustomOption.Create(285, Types.Crewmate, "Durée de l'Agent de Sécurité", 10f, 2.5f, 60f, 2.5f, securityGuardSpawnRate);
            securityGuardCamMaxCharges = CustomOption.Create(286, Types.Crewmate, "Charges Maximum des Gadgets", 5f, 1f, 30f, 1f, securityGuardSpawnRate);
            securityGuardCamRechargeTasksNumber = CustomOption.Create(287, Types.Crewmate, "Nombre de Tâches Nécessaire Pour Recharger", 3f, 1f, 10f, 1f, securityGuardSpawnRate);
            securityGuardNoMove = CustomOption.Create(288, Types.Crewmate, "Durée où il est Impossible de Bouger Dans les Cam", true, securityGuardSpawnRate);

            mediumSpawnRate = CustomOption.Create(360, Types.Crewmate, cs(Medium.color, "Médium"), rates, null, true);
            mediumCooldown = CustomOption.Create(361, Types.Crewmate, "Cooldown du Médium", 30f, 5f, 120f, 5f, mediumSpawnRate);
            mediumDuration = CustomOption.Create(362, Types.Crewmate, "Durée du Médium", 3f, 0f, 15f, 1f, mediumSpawnRate);
            mediumOneTimeUse = CustomOption.Create(363, Types.Crewmate, "Chaque Âme ne Peut Être Questionné qu'une Fois", false, mediumSpawnRate);

            // Modifier
            modifiersAreHidden = CustomOption.Create(1009, Types.Modifier, cs(Color.yellow, "Masquer les modificateurs après la mort"), true, null, true);

            modifierBloody = CustomOption.Create(1000, Types.Modifier, cs(Color.yellow, "Sanglant"), rates, null, true);
            modifierBloodyQuantity = CustomOption.Create(1001, Types.Modifier, cs(Color.yellow, "Quantité de Sanglants"), ratesModifier, modifierBloody);
            modifierBloodyDuration = CustomOption.Create(1002, Types.Modifier, "Durée de la traînée", 10f, 3f, 60f, 1f, modifierBloody);

            modifierAntiTeleport = CustomOption.Create(1010, Types.Modifier, cs(Color.yellow, "Anti Teleport"), rates, null, true);
            modifierAntiTeleportQuantity = CustomOption.Create(1011, Types.Modifier, cs(Color.yellow, "Quantité d'Anti Teleport"), ratesModifier, modifierAntiTeleport);

            modifierTieBreaker = CustomOption.Create(1020, Types.Modifier, cs(Color.yellow, "Casseur d'égalités"), rates, null, true);

            modifierBait = CustomOption.Create(1030, Types.Modifier, cs(Color.yellow, "Appât"), rates, null, true);
            modifierBaitQuantity = CustomOption.Create(1031, Types.Modifier, cs(Color.yellow, "Quantité d'Appâts"), ratesModifier, modifierBait);
            modifierBaitReportDelayMin = CustomOption.Create(1032, Types.Modifier, "Délai de report Min. des Appâts", 0f, 0f, 10f, 1f, modifierBait);
            modifierBaitReportDelayMax = CustomOption.Create(1033, Types.Modifier, "Délai de report Max. des Appâts", 0f, 0f, 10f, 1f, modifierBait);
            modifierBaitShowKillFlash = CustomOption.Create(1034, Types.Modifier, "Alerte le tueur avec un flash", true, modifierBait);

            modifierLover = CustomOption.Create(1040, Types.Modifier, cs(Color.yellow, "Amoureux"), rates, null, true);
            modifierLoverImpLoverRate = CustomOption.Create(1041, Types.Modifier, "Chance qu'un Amoureux soit imposteur", rates, modifierLover);
            modifierLoverBothDie = CustomOption.Create(1042, Types.Modifier, "Les deux Amoureux meurent", true, modifierLover);
            modifierLoverEnableChat = CustomOption.Create(1043, Types.Modifier, "Activer le chat des Amoureux", true, modifierLover);

            modifierSunglasses = CustomOption.Create(1050, Types.Modifier, cs(Color.yellow, "Lunettes de soleil"), rates, null, true);
            modifierSunglassesQuantity = CustomOption.Create(1051, Types.Modifier, cs(Color.yellow, "Quantité de Lunettes de soleil"), ratesModifier, modifierSunglasses);
            modifierSunglassesVision = CustomOption.Create(1052, Types.Modifier, "Vision avec les Lunettes de soleil", new string[] { "-10%", "-20%", "-30%", "-40%", "-50%" }, modifierSunglasses);

            modifierMini = CustomOption.Create(1061, Types.Modifier, cs(Color.yellow, "Mini"), rates, null, true);
            modifierMiniGrowingUpDuration = CustomOption.Create(1062, Types.Modifier, "Durée de croissance du mini", 400f, 100f, 1500f, 100f, modifierMini);

            modifierVip = CustomOption.Create(1070, Types.Modifier, cs(Color.yellow, "VIP"), rates, null, true);
            modifierVipQuantity = CustomOption.Create(1071, Types.Modifier, cs(Color.yellow, "Quantité de VIP"), ratesModifier, modifierVip);
            modifierVipShowColor = CustomOption.Create(1072, Types.Modifier, "Afficher la couleur de l'équipe", true, modifierVip);

            modifierInvert = CustomOption.Create(1080, Types.Modifier, cs(Color.yellow, "Inversion"), rates, null, true);
            modifierInvertQuantity = CustomOption.Create(1081, Types.Modifier, cs(Color.yellow, "Quantité de Modificateurs"), ratesModifier, modifierInvert);
            modifierInvertDuration = CustomOption.Create(1082, Types.Modifier, "Nombre de Meetings inversés", 3f, 1f, 15f, 1f, modifierInvert);

            // Other options
            maxNumberOfMeetings = CustomOption.Create(3, Types.General, "Nombre de meetings (excluant les meetings du Maire)", 10, 0, 15, 1, null, true);
            blockSkippingInEmergencyMeetings = CustomOption.Create(4, Types.General, "Bloquer les skip dans les Emergency Meetings", false);
            noVoteIsSelfVote = CustomOption.Create(5, Types.General, "Absence de vote = vote soi-même", false, blockSkippingInEmergencyMeetings);
            hidePlayerNames = CustomOption.Create(6, Types.General, "Cacher le nom des joueurs", false);
            allowParallelMedBayScans = CustomOption.Create(7, Types.General, "Autoriser les scans MedBay parallèles", false);
            shieldFirstKill = CustomOption.Create(8, Types.General, "Protèger le premier kill de la dernière game", false);

            dynamicMap = CustomOption.Create(500, Types.General, "Jouer sur une carte aléatoire", false, null, false);
            dynamicMapEnableSkeld = CustomOption.Create(501, Types.General, "Activer la Rotation de the Skeld", true, dynamicMap, false);
            dynamicMapEnableMira = CustomOption.Create(502, Types.General, "Activer la Rotation de MiraHQ", true, dynamicMap, false);
            dynamicMapEnablePolus = CustomOption.Create(503, Types.General, "Activer la Rotation de Polus", true, dynamicMap, false);
            dynamicMapEnableAirShip = CustomOption.Create(504, Types.General, "Activer la Rotation de Airship", true, dynamicMap, false);

            dynamicMapEnableSubmerged = CustomOption.Create(505, Types.General, "Activer la Rotation de Submerged", true, dynamicMap, false);

            blockedRolePairings.Add((byte)RoleId.Vampire, new [] { (byte)RoleId.Warlock});
            blockedRolePairings.Add((byte)RoleId.Warlock, new [] { (byte)RoleId.Vampire});
            blockedRolePairings.Add((byte)RoleId.Spy, new [] { (byte)RoleId.Mini});
            blockedRolePairings.Add((byte)RoleId.Mini, new [] { (byte)RoleId.Spy});
            blockedRolePairings.Add((byte)RoleId.Vulture, new [] { (byte)RoleId.Cleaner});
            blockedRolePairings.Add((byte)RoleId.Cleaner, new [] { (byte)RoleId.Vulture});
            
        }
    }
}
