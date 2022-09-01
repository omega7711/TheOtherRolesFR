using System.Linq;
using System;
using System.Collections.Generic;
using TheOtherRoles.Players;
using static TheOtherRoles.TheOtherRoles;
using UnityEngine;

namespace TheOtherRoles
{
    class RoleInfo {
        public Color color;
        public string name;
        public string introDescription;
        public string shortDescription;
        public RoleId roleId;
        public bool isNeutral;
        public bool isModifier;

        RoleInfo(string name, Color color, string introDescription, string shortDescription, RoleId roleId, bool isNeutral = false, bool isModifier = false) {
            this.color = color;
            this.name = name;
            this.introDescription = introDescription;
            this.shortDescription = shortDescription;
            this.roleId = roleId;
            this.isNeutral = isNeutral;
            this.isModifier = isModifier;
        }

        public static RoleInfo jester = new RoleInfo("Bouffon", Jester.color, "Soyez éjecté", "Soyez éjecté", RoleId.Jester, true);
        public static RoleInfo mayor = new RoleInfo("Maire", Mayor.color, "Votre vote compte double", "Votre vote compte double", RoleId.Mayor);
        public static RoleInfo portalmaker = new RoleInfo("Dieu du portail", Portalmaker.color, "Vous pouvez créer des portails", "Vous pouvez créer des portails", RoleId.Portalmaker);
        public static RoleInfo engineer = new RoleInfo("Ingénieur",  Engineer.color, "Maintenez les systèmes importants sur le vaisseau", "Réparez le vaisseau", RoleId.Engineer);
        public static RoleInfo sheriff = new RoleInfo("Shérif", Sheriff.color, "Tirez sur les <color=#FF1919FF>Imposteurs</color>", "Tirez sur les Imposteurs", RoleId.Sheriff);
        public static RoleInfo deputy = new RoleInfo("Adjoint", Sheriff.color, "Menottez les <color=#FF1919FF>Imposteurs</color>", "Menottez les Imposteurs", RoleId.Deputy);
        public static RoleInfo lighter = new RoleInfo("Eclaireur", Lighter.color, "Votre lumière ne s'éteint jamais", "Votre lumière ne s'éteint jamais", RoleId.Lighter);
        public static RoleInfo godfather = new RoleInfo("Parrain", Godfather.color, "Tuez tous les Crewmates", "Tuez tous les Crewmates", RoleId.Godfather);
        public static RoleInfo mafioso = new RoleInfo("Mafieux", Mafioso.color, "Travaille avec la <color=#FF1919FF>Mafia</color> pour tuer les Crewmates", "Tuez tous les Crewmates", RoleId.Mafioso);
        public static RoleInfo janitor = new RoleInfo("Concierge", Janitor.color, "Travaille avec la <color=#FF1919FF>Mafia</color> en cachant les corps", "Cachez les corps", RoleId.Janitor);
        public static RoleInfo morphling = new RoleInfo("Morphling", Morphling.color, "Changez votre apparence pour ne pas vous faire attraper", "Changez d'apparence", RoleId.Morphling);
        public static RoleInfo camouflager = new RoleInfo("Camoufleur", Camouflager.color, "Camouflez vous et tuez les Crewmates", "Cachez vous parmis les autres", RoleId.Camouflager);
        public static RoleInfo vampire = new RoleInfo("Vampire", Vampire.color, "Tuez les Crewmates avec vos morsures", "Mordez vos ennemis", RoleId.Vampire);
        public static RoleInfo eraser = new RoleInfo("Effaceur", Eraser.color, "Tuez les Crewmates et effacez leurs rôles", "Effacez les rôles de vos ennemis", RoleId.Eraser);
        public static RoleInfo trickster = new RoleInfo("Filou", Trickster.color, "Utilisez vos jack-in-the-boxes pour surprendre les autres", "Surprenez vos ennemis", RoleId.Trickster);
        public static RoleInfo cleaner = new RoleInfo("Nettoyeur", Cleaner.color, "Tuez tout le monde et ne laissez aucune trace", "Nettoyez les corps", RoleId.Cleaner);
        public static RoleInfo warlock = new RoleInfo("Sorcier", Warlock.color, "Maudissez les autres joueurs et tuez tout le monde", "Maudissez et tuez tout le monde", RoleId.Warlock);
        public static RoleInfo bountyHunter = new RoleInfo("Mandalorian", BountyHunter.color, "Chassez votre prime", "Chassez votre prime", RoleId.BountyHunter);
        public static RoleInfo detective = new RoleInfo("Détéctive", Detective.color, "Trouvez les <color=#FF1919FF>Imposteurs</color> en examinants les empruntes de pas", "Examinez les empruntes de pas", RoleId.Detective);
        public static RoleInfo timeMaster = new RoleInfo("Maître du temps", TimeMaster.color, "Sauve toi toi-même avec ton bouclier temporel", "Utilise ton bouclier temporel", RoleId.TimeMaster);
        public static RoleInfo medic = new RoleInfo("Médecin", Medic.color, "Protègez quelqu'un avec votre bouvlier", "Protègez les autres joueurs", RoleId.Medic);
        public static RoleInfo shifter = new RoleInfo("Shifter", Shifter.color, "Changez votre rôle", "Changez votre rôle", RoleId.Shifter);
        public static RoleInfo swapper = new RoleInfo("Swapeur", Swapper.color, "Echangez les votes pour éxiler les <color=#FF1919FF>Imposteurs</color>", "Echangez les votes", RoleId.Swapper);
        public static RoleInfo seer = new RoleInfo("Voyant", Seer.color, "Vous verrez des joueurs mourir", "Vous verrez des joueurs mourir", RoleId.Seer);
        public static RoleInfo hacker = new RoleInfo("Hacker", Hacker.color, "Hackez les systèmes pour trouver les <color=#FF1919FF>Imposteurs</color>", "Hackez pour trouver les Imposteurs", RoleId.Hacker);
        public static RoleInfo tracker = new RoleInfo("Pisteur", Tracker.color, "Pistez les <color=#FF1919FF>Imposteurs</color>", "Pistez les Imposteurs", RoleId.Tracker);
        public static RoleInfo snitch = new RoleInfo("Mouchard", Snitch.color, "Finissez les tâches pour trouver les <color=#FF1919FF>Imposteurs</color>", "Finissez vos tâches", RoleId.Snitch);
        public static RoleInfo jackal = new RoleInfo("Chacal", Jackal.color, "Tuez tous les Crewmates et les <color=#FF1919FF>Imposteurs</color> pour gagner", "Tuez tout le monde", RoleId.Jackal, true);
        public static RoleInfo sidekick = new RoleInfo("Acolyte", Sidekick.color, "Aidez votre Jackal à tuer tout le monde", "Aidez votre Jackal à tuer tout le monde", RoleId.Sidekick, true);
        public static RoleInfo spy = new RoleInfo("Espion", Spy.color, "Embrouillez les <color=#FF1919FF>Imposteurs</color>", "Embrouillez les Imposteurs", RoleId.Spy);
        public static RoleInfo securityGuard = new RoleInfo("Agent de sécurité", SecurityGuard.color, "Scellez les vents et placez des caméras", "Scellez les vents et placez des caméras", RoleId.SecurityGuard);
        public static RoleInfo arsonist = new RoleInfo("Incendiaire", Arsonist.color, "Laissez-les brûler", "Laissez-les brûler", RoleId.Arsonist, true);
        public static RoleInfo goodGuesser = new RoleInfo("Gentil devin", Guesser.color, "Devinez et tirez", "Devinez et tirez", RoleId.NiceGuesser);
        public static RoleInfo badGuesser = new RoleInfo("Devin maléfique", Palette.ImpostorRed, "Devinez et tirez", "Devinez et tirez", RoleId.EvilGuesser);
        public static RoleInfo vulture = new RoleInfo("Vautour", Vulture.color, "Mangez les corps pour gagner", "Mangez les corps", RoleId.Vulture, true);
        public static RoleInfo medium = new RoleInfo("Médium", Medium.color, "Questionnez les âmes des morts pour obtenir des informations", "Questionnez les âmes", RoleId.Medium);
        public static RoleInfo lawyer = new RoleInfo("Avocat", Lawyer.color, "Défendez votre client", "Défendez votre client", RoleId.Lawyer, true);
        public static RoleInfo pursuer = new RoleInfo("Pursuer", Pursuer.color, "Blank the Impostors", "Blank the Impostors", RoleId.Pursuer);
        public static RoleInfo impostor = new RoleInfo("Impostor", Palette.ImpostorRed, Helpers.cs(Palette.ImpostorRed, "Sabotez et tuez tout le monde"), "Sabotez et tuez tout le monde", RoleId.Impostor);
        public static RoleInfo crewmate = new RoleInfo("Crewmate", Color.white, "Trouvez les Imposteurs", "Trouvez les Imposteurs", RoleId.Crewmate);
        public static RoleInfo witch = new RoleInfo("Witch", Witch.color, "Jetez un sort à vos ennemis", "Jetez un sort à vos ennemis", RoleId.Witch);
        public static RoleInfo ninja = new RoleInfo("Ninja", Ninja.color, "Surprenez et assassinez vos ennemis", "Surprenez et assassinez vos ennemis", RoleId.Ninja);



        // Modifier
        public static RoleInfo bloody = new RoleInfo("Sanglant", Color.yellow, "Votre tueur laisse une traînée de sang", "Your killer leaves a bloody trail", RoleId.Bloody, false, true);
        public static RoleInfo antiTeleport = new RoleInfo("Anti tp", Color.yellow, "Vous ne serez pas téléporté", "Vous ne serez pas téléporté", RoleId.AntiTeleport, false, true);
        public static RoleInfo tiebreaker = new RoleInfo("Casseur d'égalité", Color.yellow, "Votre vote casse l'égalité", "Cassez l'égalité", RoleId.Tiebreaker, false, true);
        public static RoleInfo bait = new RoleInfo("Appât", Color.yellow, "Appâtez vos ennemis", "Appâtez vos ennemis", RoleId.Bait, false, true);
        public static RoleInfo sunglasses = new RoleInfo("Lunettes de Soleil", Color.yellow, "Vous avez des Lunnettes de soleil", "Votre vision est réduite", RoleId.Sunglasses, false, true);
        public static RoleInfo lover = new RoleInfo("Amoureux", Lovers.color, $"Vous êtes amoureux", $"Vous êtes amoureux", RoleId.Lover, false, true);
        public static RoleInfo mini = new RoleInfo("Mini", Color.yellow, "Personne ne vous fera de mal jusqu'à que vous soyez grand", "Personne ne vous fera de mal", RoleId.Mini, false, true);
        public static RoleInfo vip = new RoleInfo("VIP", Color.yellow, "Vous êtes le VIP", "Tout le monde est notifié quand vous mourrez", RoleId.Vip, false, true);
        public static RoleInfo invert = new RoleInfo("Inversion", Color.yellow, "Vos mouvement sont inversés", "Vos mouvement sont inversés", RoleId.Invert, false, true);


        public static List<RoleInfo> allRoleInfos = new List<RoleInfo>() {
            impostor,
            godfather,
            mafioso,
            janitor,
            morphling,
            camouflager,
            vampire,
            eraser,
            trickster,
            cleaner,
            warlock,
            bountyHunter,
            witch,
            ninja,
            goodGuesser,
            badGuesser,
            lover,
            jester,
            arsonist,
            jackal,
            sidekick,
            vulture,
            pursuer,
            lawyer,
            crewmate,
            shifter,
            mayor,
            portalmaker,
            engineer,
            sheriff,
            deputy,
            lighter,
            detective,
            timeMaster,
            medic,
            swapper,
            seer,
            hacker,
            tracker,
            snitch,
            spy,
            securityGuard,
            bait,
            medium,
            bloody,
            antiTeleport,
            tiebreaker,
            sunglasses,
            mini,
            vip,
            invert
        };

        public static List<RoleInfo> getRoleInfoForPlayer(PlayerControl p, bool showModifier = true) {
            List<RoleInfo> infos = new List<RoleInfo>();
            if (p == null) return infos;

            // Modifier
            if (showModifier) {
                // after dead modifier
                if (!CustomOptionHolder.modifiersAreHidden.getBool() || PlayerControl.LocalPlayer.Data.IsDead)
                {
                    if (Bait.bait.Any(x => x.PlayerId == p.PlayerId)) infos.Add(bait);
                    if (Bloody.bloody.Any(x => x.PlayerId == p.PlayerId)) infos.Add(bloody);
                    if (Vip.vip.Any(x => x.PlayerId == p.PlayerId)) infos.Add(vip);
                }
                if (p == Lovers.lover1 || p == Lovers.lover2) infos.Add(lover);
                if (p == Tiebreaker.tiebreaker) infos.Add(tiebreaker);
                if (AntiTeleport.antiTeleport.Any(x => x.PlayerId == p.PlayerId)) infos.Add(antiTeleport);
                if (Sunglasses.sunglasses.Any(x => x.PlayerId == p.PlayerId)) infos.Add(sunglasses);
                if (p == Mini.mini) infos.Add(mini);
                if (Invert.invert.Any(x => x.PlayerId == p.PlayerId)) infos.Add(invert);
            }

            // Special roles
            if (p == Jester.jester) infos.Add(jester);
            if (p == Mayor.mayor) infos.Add(mayor);
            if (p == Portalmaker.portalmaker) infos.Add(portalmaker);
            if (p == Engineer.engineer) infos.Add(engineer);
            if (p == Sheriff.sheriff || p == Sheriff.formerSheriff) infos.Add(sheriff);
            if (p == Deputy.deputy) infos.Add(deputy);
            if (p == Lighter.lighter) infos.Add(lighter);
            if (p == Godfather.godfather) infos.Add(godfather);
            if (p == Mafioso.mafioso) infos.Add(mafioso);
            if (p == Janitor.janitor) infos.Add(janitor);
            if (p == Morphling.morphling) infos.Add(morphling);
            if (p == Camouflager.camouflager) infos.Add(camouflager);
            if (p == Vampire.vampire) infos.Add(vampire);
            if (p == Eraser.eraser) infos.Add(eraser);
            if (p == Trickster.trickster) infos.Add(trickster);
            if (p == Cleaner.cleaner) infos.Add(cleaner);
            if (p == Warlock.warlock) infos.Add(warlock);
            if (p == Witch.witch) infos.Add(witch);
            if (p == Ninja.ninja) infos.Add(ninja);
            if (p == Detective.detective) infos.Add(detective);
            if (p == TimeMaster.timeMaster) infos.Add(timeMaster);
            if (p == Medic.medic) infos.Add(medic);
            if (p == Shifter.shifter) infos.Add(shifter);
            if (p == Swapper.swapper) infos.Add(swapper);
            if (p == Seer.seer) infos.Add(seer);
            if (p == Hacker.hacker) infos.Add(hacker);
            if (p == Tracker.tracker) infos.Add(tracker);
            if (p == Snitch.snitch) infos.Add(snitch);
            if (p == Jackal.jackal || (Jackal.formerJackals != null && Jackal.formerJackals.Any(x => x.PlayerId == p.PlayerId))) infos.Add(jackal);
            if (p == Sidekick.sidekick) infos.Add(sidekick);
            if (p == Spy.spy) infos.Add(spy);
            if (p == SecurityGuard.securityGuard) infos.Add(securityGuard);
            if (p == Arsonist.arsonist) infos.Add(arsonist);
            if (p == Guesser.niceGuesser) infos.Add(goodGuesser);
            if (p == Guesser.evilGuesser) infos.Add(badGuesser);
            if (p == BountyHunter.bountyHunter) infos.Add(bountyHunter);
            if (p == Vulture.vulture) infos.Add(vulture);
            if (p == Medium.medium) infos.Add(medium);
            if (p == Lawyer.lawyer) infos.Add(lawyer);
            if (p == Pursuer.pursuer) infos.Add(pursuer);

            // Default roles
            if (infos.Count == 0 && p.Data.Role.IsImpostor) infos.Add(impostor); // Just Impostor
            if (infos.Count == 0 && !p.Data.Role.IsImpostor) infos.Add(crewmate); // Just Crewmate

            return infos;
        }

        public static String GetRolesString(PlayerControl p, bool useColors, bool showModifier = true) {
            string roleName;
            roleName = String.Join(" ", getRoleInfoForPlayer(p, showModifier).Select(x => useColors ? Helpers.cs(x.color, x.name) : x.name).ToArray());
            if (Lawyer.target != null && p.PlayerId == Lawyer.target.PlayerId && CachedPlayer.LocalPlayer.PlayerControl != Lawyer.target) roleName += (useColors ? Helpers.cs(Pursuer.color, " §") : " §");
            return roleName;
        }
    }
}
