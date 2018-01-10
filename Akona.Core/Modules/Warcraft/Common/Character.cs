using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Akona.Core.Common;
using Akona.Core.Services;
using Akona.Core.Services.Database.Models;

namespace Akona.Core.Modules.Warcraft.Common {
    public class Character {
        public bool _success = false;
        WoWCharacterModel _character = new WoWCharacterModel();

        public Character(string name, string realm) {
            string url = String.Format(Alerts.GetFormattedAlert("CHARURL",
                                                                realm,
                                                                name,
                                                                Configuration.bot.WoWAPIKey));
            string stats = Utilities.FetchWebResponse<string>(url);
            if (stats != "Error fetching data.") {
                /* Need to replace the key words class and int that come in the 
                 * response from Blizzard to m_class and intellect. Otherwise it
                 * won't work. TODO: Find a more elegant solution. */
                var replaceClassInJson = new Regex(Regex.Escape("\"class\""));  // Change "class"
                var replaceIntInJson = new Regex(Regex.Escape("\"int\""));      // Change "int"
                stats = replaceClassInJson.Replace(stats, "\"m_class\"", 1);    // ...to "m_class"
                stats = replaceIntInJson.Replace(stats, "\"intellect\"", 1);    // ...to "intellect"

                // Convert JSON to CharacterModel object.
                _character = Utilities.DeserializeJsonToString<WoWCharacterModel>(stats);
                _success = true;
            } else {
                Console.WriteLine("Error fetching data from Blizzard API.");
                return;
            }  // End if (stats != "Error fetching data.") && else
        }  // public Character(string name, string realm)

        public string getName() { return _character.name; }
        public string getRealm() { return _character.realm; }
        public string getClass() {
            switch (_character.m_class) {
                case 1: return "Warrior";
                case 2: return "Paladin";
                case 3: return "Hunter";
                case 4: return "Rogue";
                case 5: return "Priest";
                case 6: return "Death Knight";
                case 7: return "Shaman";
                case 8: return "Mage";
                case 9: return "Warlock";
                case 10: return "Monk";
                case 11: return "Druid";
                case 12: return "Demon Hunter";
                default: return "Error";
            }
        }

        public int[] getClassColor() {
            int[] color = { 0, 0, 0 };
            switch (_character.m_class) {
                case 1: color[0] = 199; color[1] = 156; color[2] = 110; return color;
                case 2: color[0] = 245; color[1] = 140; color[2] = 186; return color;
                case 3: color[0] = 171; color[1] = 212; color[2] = 115; return color;
                case 4: color[0] = 255; color[1] = 145; color[2] = 105; return color;
                case 5: color[0] = 255; color[1] = 255; color[2] = 255; return color;
                case 6: color[0] = 196; color[1] = 030; color[2] = 059; return color;
                case 7: color[0] = 000; color[1] = 112; color[2] = 222; return color;
                case 8: color[0] = 105; color[1] = 204; color[2] = 240; return color;
                case 9: color[0] = 148; color[1] = 130; color[2] = 201; return color;
                case 10: color[0] = 000; color[1] = 255; color[2] = 180; return color;
                case 11: color[0] = 255; color[1] = 125; color[2] = 010; return color;
                case 12: color[0] = 163; color[1] = 048; color[2] = 201; return color;
                default: color[0] = 000; color[1] = 000; color[2] = 000; return color;
            }
        }
        public int getiLevel() { return _character.items.averageItemLevelEquipped; }
        public string getSpec() { return _character.talents[0].spec.name; }
        public string getThumbnail() { return _character.thumbnail; }
        public int getLevel() { return _character.level; }
        public int getHealth() { return _character.stats.health; }
        public int getPower() { return _character.stats.power; }
        public int getAchievementPoints() { return _character.achievementPoints; }

        private string getProgression(int raidNumber) {
            Raid raid = _character.progression.raids[raidNumber];

            string mode = "";
            int[] bossesKilled = { 0, 0, 0, 0 };
            int returnBossesKilled = 0;
            for (int i = 0; i < raid.bosses.Length; i++) {
                if (raid.bosses[i].lfrKills > 0) {
                    bossesKilled[0]++;
                }
                if (raid.bosses[i].normalKills > 0) {
                    bossesKilled[1]++;
                }
                if (raid.bosses[i].heroicKills > 0) {
                    bossesKilled[2]++;
                }
                if (raid.bosses[i].mythicKills > 0) {
                    bossesKilled[3]++;
                }
            }

            for (int j = bossesKilled.Length - 1; j >= 0; j--) {
                if (bossesKilled[j] > 0) {
                    switch (j) {
                        case 1: mode = "N"; break;  // Normal 
                        case 2: mode = "H"; break;  // Heroic
                        case 3: mode = "M"; break;  // Mythic
                    }
                    returnBossesKilled = bossesKilled[j];
                    break;
                }
            }
            return String.Format("{0}/{1}{2}",
                                 returnBossesKilled,
                                 raid.bosses.Length,
                                 mode);
        }

        public string getENProgress() {
            return getProgression(35);  // Emerald Nightmare
        }
        public string getToVProgress() {
            return getProgression(36);  // Trial of Valor
        }
        public string getNHProgress() {
            return getProgression(37);  // Nighthold
        }
        public string getToSProgress() {
            return getProgression(38);  // Tomb of Sargeras
        }
        public string getAntorusProgress() {
            return getProgression(39);  // Antorus
        }

        public int getArtifactTraits() {
            int artifactTraits = 0;
            int relicCount = _character.items.mainHand.relics.Length;
            var artifactTraitArray = _character.items.mainHand.artifactTraits;
            for (int i = 0; i < artifactTraitArray.Length; i++) {
                artifactTraits += artifactTraitArray[i].rank;
            }
            return artifactTraits - relicCount;  // Total artifact traits - the points the relics add.
        }

        public int getAgility() {
            return _character.stats.agi;
        }

        public int getStrength() {
            return _character.stats.str;
        }

        public int getIntellect() {
            return _character.stats.intellect;
        }

        public int getCrit() {
            return (int)_character.stats.crit;
        }

        public int getHaste() {
            return (int)_character.stats.haste;
        }

        public int getMastery() {
            return (int)_character.stats.mastery;
        }

        public int getVers() {
            /* versatilityDamageDoneBonus is used instead because for some
             * reason, CharacterModel.versatility is parsed incorrectly. */
            return (int)_character.stats.versatilityDamageDoneBonus;
        }
    }  // public class Character
}
