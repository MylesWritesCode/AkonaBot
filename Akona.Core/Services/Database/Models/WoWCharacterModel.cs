using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Akona.Core.Services.Database.Models {
        public class WoWCharacterModel {
        public long lastModified { get; set; }
        public string name { get; set; }
        public string realm { get; set; }
        public string battlegroup { get; set; }
        public int m_class { get; set; }
        public int race { get; set; }
        public int gender { get; set; }
        public int level { get; set; }
        public int achievementPoints { get; set; }
        public string thumbnail { get; set; }
        public string calcClass { get; set; }
        public int faction { get; set; }
        public Items items { get; set; }
        public Stats stats { get; set; }
        public Talent[] talents { get; set; }
        public Progression progression { get; set; }
        public int totalHonorableKills { get; set; }
    }

    public class Items {
        public int averageItemLevel { get; set; }
        public int averageItemLevelEquipped { get; set; }
        public Head head { get; set; }
        public Neck neck { get; set; }
        public Shoulder shoulder { get; set; }
        public Back back { get; set; }
        public Chest chest { get; set; }
        public Tabard tabard { get; set; }
        public Wrist wrist { get; set; }
        public Hands hands { get; set; }
        public Waist waist { get; set; }
        public Legs legs { get; set; }
        public Feet feet { get; set; }
        public Finger1 finger1 { get; set; }
        public Finger2 finger2 { get; set; }
        public Trinket1 trinket1 { get; set; }
        public Trinket2 trinket2 { get; set; }
        public Mainhand mainHand { get; set; }
        public Offhand offHand { get; set; }
    }

    public class Head {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int quality { get; set; }
        public int itemLevel { get; set; }
        public Tooltipparams tooltipParams { get; set; }
        public Stat[] stats { get; set; }
        public int armor { get; set; }
        public string context { get; set; }
        public int[] bonusLists { get; set; }
        public int artifactId { get; set; }
        public int displayInfoId { get; set; }
        public int artifactAppearanceId { get; set; }
        public object[] artifactTraits { get; set; }
        public object[] relics { get; set; }
        public Appearance appearance { get; set; }
    }

    public class Tooltipparams {
        public int transmogItem { get; set; }
        public int timewalkerLevel { get; set; }
    }

    public class Appearance {
        public int itemId { get; set; }
        public int itemAppearanceModId { get; set; }
        public int transmogItemAppearanceModId { get; set; }
    }

    public class Stat {
        public int stat { get; set; }
        public int amount { get; set; }
    }

    public class Neck {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int quality { get; set; }
        public int itemLevel { get; set; }
        public Tooltipparams1 tooltipParams { get; set; }
        public Stat1[] stats { get; set; }
        public int armor { get; set; }
        public string context { get; set; }
        public int[] bonusLists { get; set; }
        public int artifactId { get; set; }
        public int displayInfoId { get; set; }
        public int artifactAppearanceId { get; set; }
        public object[] artifactTraits { get; set; }
        public object[] relics { get; set; }
        public Appearance1 appearance { get; set; }
    }

    public class Tooltipparams1 {
        public int enchant { get; set; }
        public int timewalkerLevel { get; set; }
    }

    public class Appearance1 {
        public int enchantDisplayInfoId { get; set; }
    }

    public class Stat1 {
        public int stat { get; set; }
        public int amount { get; set; }
    }

    public class Shoulder {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int quality { get; set; }
        public int itemLevel { get; set; }
        public Tooltipparams2 tooltipParams { get; set; }
        public Stat2[] stats { get; set; }
        public int armor { get; set; }
        public string context { get; set; }
        public int[] bonusLists { get; set; }
        public int artifactId { get; set; }
        public int displayInfoId { get; set; }
        public int artifactAppearanceId { get; set; }
        public object[] artifactTraits { get; set; }
        public object[] relics { get; set; }
        public Appearance2 appearance { get; set; }
    }

    public class Tooltipparams2 {
        public int gem0 { get; set; }
        public int enchant { get; set; }
        public int transmogItem { get; set; }
        public int timewalkerLevel { get; set; }
    }

    public class Appearance2 {
        public int itemId { get; set; }
        public int enchantDisplayInfoId { get; set; }
        public int itemAppearanceModId { get; set; }
        public int transmogItemAppearanceModId { get; set; }
    }

    public class Stat2 {
        public int stat { get; set; }
        public int amount { get; set; }
    }

    public class Back {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int quality { get; set; }
        public int itemLevel { get; set; }
        public Tooltipparams3 tooltipParams { get; set; }
        public Stat3[] stats { get; set; }
        public int armor { get; set; }
        public string context { get; set; }
        public int[] bonusLists { get; set; }
        public int artifactId { get; set; }
        public int displayInfoId { get; set; }
        public int artifactAppearanceId { get; set; }
        public object[] artifactTraits { get; set; }
        public object[] relics { get; set; }
        public Appearance3 appearance { get; set; }
    }

    public class Tooltipparams3 {
        public int enchant { get; set; }
        public int tinker { get; set; }
        public int[] set { get; set; }
        public int transmogItem { get; set; }
        public int timewalkerLevel { get; set; }
    }

    public class Appearance3 {
        public int itemId { get; set; }
        public int enchantDisplayInfoId { get; set; }
        public int itemAppearanceModId { get; set; }
        public int transmogItemAppearanceModId { get; set; }
    }

    public class Stat3 {
        public int stat { get; set; }
        public int amount { get; set; }
    }

    public class Chest {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int quality { get; set; }
        public int itemLevel { get; set; }
        public Tooltipparams4 tooltipParams { get; set; }
        public Stat4[] stats { get; set; }
        public int armor { get; set; }
        public string context { get; set; }
        public int[] bonusLists { get; set; }
        public int artifactId { get; set; }
        public int displayInfoId { get; set; }
        public int artifactAppearanceId { get; set; }
        public object[] artifactTraits { get; set; }
        public object[] relics { get; set; }
        public Appearance4 appearance { get; set; }
    }

    public class Tooltipparams4 {
        public int[] set { get; set; }
        public int transmogItem { get; set; }
        public int timewalkerLevel { get; set; }
    }

    public class Appearance4 {
        public int itemId { get; set; }
        public int itemAppearanceModId { get; set; }
        public int transmogItemAppearanceModId { get; set; }
    }

    public class Stat4 {
        public int stat { get; set; }
        public int amount { get; set; }
    }

    public class Tabard {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int quality { get; set; }
        public int itemLevel { get; set; }
        public Tooltipparams5 tooltipParams { get; set; }
        public object[] stats { get; set; }
        public int armor { get; set; }
        public string context { get; set; }
        public object[] bonusLists { get; set; }
        public int artifactId { get; set; }
        public int displayInfoId { get; set; }
        public int artifactAppearanceId { get; set; }
        public object[] artifactTraits { get; set; }
        public object[] relics { get; set; }
        public Appearance5 appearance { get; set; }
    }

    public class Tooltipparams5 {
        public int transmogItem { get; set; }
        public int timewalkerLevel { get; set; }
    }

    public class Appearance5 {
        public int itemId { get; set; }
        public int itemAppearanceModId { get; set; }
        public int transmogItemAppearanceModId { get; set; }
    }

    public class Wrist {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int quality { get; set; }
        public int itemLevel { get; set; }
        public Tooltipparams6 tooltipParams { get; set; }
        public Stat5[] stats { get; set; }
        public int armor { get; set; }
        public string context { get; set; }
        public int[] bonusLists { get; set; }
        public int artifactId { get; set; }
        public int displayInfoId { get; set; }
        public int artifactAppearanceId { get; set; }
        public object[] artifactTraits { get; set; }
        public object[] relics { get; set; }
        public Appearance6 appearance { get; set; }
    }

    public class Tooltipparams6 {
        public int transmogItem { get; set; }
        public int timewalkerLevel { get; set; }
    }

    public class Appearance6 {
        public int itemId { get; set; }
        public int itemAppearanceModId { get; set; }
        public int transmogItemAppearanceModId { get; set; }
    }

    public class Stat5 {
        public int stat { get; set; }
        public int amount { get; set; }
    }

    public class Hands {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int quality { get; set; }
        public int itemLevel { get; set; }
        public Tooltipparams7 tooltipParams { get; set; }
        public Stat6[] stats { get; set; }
        public int armor { get; set; }
        public string context { get; set; }
        public int[] bonusLists { get; set; }
        public int artifactId { get; set; }
        public int displayInfoId { get; set; }
        public int artifactAppearanceId { get; set; }
        public object[] artifactTraits { get; set; }
        public object[] relics { get; set; }
        public Appearance7 appearance { get; set; }
    }

    public class Tooltipparams7 {
        public int enchant { get; set; }
        public int[] set { get; set; }
        public int transmogItem { get; set; }
        public int timewalkerLevel { get; set; }
    }

    public class Appearance7 {
        public int itemId { get; set; }
        public int enchantDisplayInfoId { get; set; }
        public int itemAppearanceModId { get; set; }
        public int transmogItemAppearanceModId { get; set; }
    }

    public class Stat6 {
        public int stat { get; set; }
        public int amount { get; set; }
    }

    public class Waist {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int quality { get; set; }
        public int itemLevel { get; set; }
        public Tooltipparams8 tooltipParams { get; set; }
        public Stat7[] stats { get; set; }
        public int armor { get; set; }
        public string context { get; set; }
        public int[] bonusLists { get; set; }
        public int artifactId { get; set; }
        public int displayInfoId { get; set; }
        public int artifactAppearanceId { get; set; }
        public object[] artifactTraits { get; set; }
        public object[] relics { get; set; }
        public Appearance8 appearance { get; set; }
    }

    public class Tooltipparams8 {
        public int transmogItem { get; set; }
        public int timewalkerLevel { get; set; }
    }

    public class Appearance8 {
        public int itemId { get; set; }
        public int itemAppearanceModId { get; set; }
        public int transmogItemAppearanceModId { get; set; }
    }

    public class Stat7 {
        public int stat { get; set; }
        public int amount { get; set; }
    }

    public class Legs {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int quality { get; set; }
        public int itemLevel { get; set; }
        public Tooltipparams9 tooltipParams { get; set; }
        public Stat8[] stats { get; set; }
        public int armor { get; set; }
        public string context { get; set; }
        public int[] bonusLists { get; set; }
        public int artifactId { get; set; }
        public int displayInfoId { get; set; }
        public int artifactAppearanceId { get; set; }
        public object[] artifactTraits { get; set; }
        public object[] relics { get; set; }
        public Appearance9 appearance { get; set; }
    }

    public class Tooltipparams9 {
        public int[] set { get; set; }
        public int transmogItem { get; set; }
        public int timewalkerLevel { get; set; }
    }

    public class Appearance9 {
        public int itemId { get; set; }
        public int itemAppearanceModId { get; set; }
        public int transmogItemAppearanceModId { get; set; }
    }

    public class Stat8 {
        public int stat { get; set; }
        public int amount { get; set; }
    }

    public class Feet {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int quality { get; set; }
        public int itemLevel { get; set; }
        public Tooltipparams10 tooltipParams { get; set; }
        public Stat9[] stats { get; set; }
        public int armor { get; set; }
        public string context { get; set; }
        public int[] bonusLists { get; set; }
        public int artifactId { get; set; }
        public int displayInfoId { get; set; }
        public int artifactAppearanceId { get; set; }
        public object[] artifactTraits { get; set; }
        public object[] relics { get; set; }
        public Appearance10 appearance { get; set; }
    }

    public class Tooltipparams10 {
        public int transmogItem { get; set; }
        public int timewalkerLevel { get; set; }
    }

    public class Appearance10 {
        public int itemId { get; set; }
        public int itemAppearanceModId { get; set; }
        public int transmogItemAppearanceModId { get; set; }
    }

    public class Stat9 {
        public int stat { get; set; }
        public int amount { get; set; }
    }

    public class Finger1 {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int quality { get; set; }
        public int itemLevel { get; set; }
        public Tooltipparams11 tooltipParams { get; set; }
        public Stat10[] stats { get; set; }
        public int armor { get; set; }
        public string context { get; set; }
        public int[] bonusLists { get; set; }
        public int artifactId { get; set; }
        public int displayInfoId { get; set; }
        public int artifactAppearanceId { get; set; }
        public object[] artifactTraits { get; set; }
        public object[] relics { get; set; }
        public Appearance11 appearance { get; set; }
    }

    public class Tooltipparams11 {
        public int gem0 { get; set; }
        public int enchant { get; set; }
        public int timewalkerLevel { get; set; }
    }

    public class Appearance11 {
        public int enchantDisplayInfoId { get; set; }
    }

    public class Stat10 {
        public int stat { get; set; }
        public int amount { get; set; }
    }

    public class Finger2 {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int quality { get; set; }
        public int itemLevel { get; set; }
        public Tooltipparams12 tooltipParams { get; set; }
        public Stat11[] stats { get; set; }
        public int armor { get; set; }
        public string context { get; set; }
        public int[] bonusLists { get; set; }
        public int artifactId { get; set; }
        public int displayInfoId { get; set; }
        public int artifactAppearanceId { get; set; }
        public object[] artifactTraits { get; set; }
        public object[] relics { get; set; }
        public Appearance12 appearance { get; set; }
    }

    public class Tooltipparams12 {
        public int gem0 { get; set; }
        public int enchant { get; set; }
        public int timewalkerLevel { get; set; }
    }

    public class Appearance12 {
        public int enchantDisplayInfoId { get; set; }
        public int itemAppearanceModId { get; set; }
    }

    public class Stat11 {
        public int stat { get; set; }
        public int amount { get; set; }
    }

    public class Trinket1 {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int quality { get; set; }
        public int itemLevel { get; set; }
        public Tooltipparams13 tooltipParams { get; set; }
        public Stat12[] stats { get; set; }
        public int armor { get; set; }
        public string context { get; set; }
        public int[] bonusLists { get; set; }
        public int artifactId { get; set; }
        public int displayInfoId { get; set; }
        public int artifactAppearanceId { get; set; }
        public object[] artifactTraits { get; set; }
        public object[] relics { get; set; }
        public Appearance13 appearance { get; set; }
    }

    public class Tooltipparams13 {
        public int timewalkerLevel { get; set; }
    }

    public class Appearance13 {
    }

    public class Stat12 {
        public int stat { get; set; }
        public int amount { get; set; }
    }

    public class Trinket2 {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int quality { get; set; }
        public int itemLevel { get; set; }
        public Tooltipparams14 tooltipParams { get; set; }
        public Stat13[] stats { get; set; }
        public int armor { get; set; }
        public string context { get; set; }
        public int[] bonusLists { get; set; }
        public int artifactId { get; set; }
        public int displayInfoId { get; set; }
        public int artifactAppearanceId { get; set; }
        public object[] artifactTraits { get; set; }
        public object[] relics { get; set; }
        public Appearance14 appearance { get; set; }
    }

    public class Tooltipparams14 {
        public int timewalkerLevel { get; set; }
    }

    public class Appearance14 {
    }

    public class Stat13 {
        public int stat { get; set; }
        public int amount { get; set; }
    }

    public class Mainhand {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int quality { get; set; }
        public int itemLevel { get; set; }
        public Tooltipparams15 tooltipParams { get; set; }
        public Stat14[] stats { get; set; }
        public int armor { get; set; }
        public Weaponinfo weaponInfo { get; set; }
        public string context { get; set; }
        public int[] bonusLists { get; set; }
        public int artifactId { get; set; }
        public int displayInfoId { get; set; }
        public int artifactAppearanceId { get; set; }
        public Artifacttrait[] artifactTraits { get; set; }
        public Relic[] relics { get; set; }
        public Appearance15 appearance { get; set; }
    }

    public class Tooltipparams15 {
        public int gem0 { get; set; }
        public int gem1 { get; set; }
        public int gem2 { get; set; }
        public int timewalkerLevel { get; set; }
    }

    public class Weaponinfo {
        public Damage damage { get; set; }
        public float weaponSpeed { get; set; }
        public float dps { get; set; }
    }

    public class Damage {
        public int min { get; set; }
        public int max { get; set; }
        public float exactMin { get; set; }
        public float exactMax { get; set; }
    }

    public class Appearance15 {
        public int itemAppearanceModId { get; set; }
    }

    public class Stat14 {
        public int stat { get; set; }
        public int amount { get; set; }
    }

    public class Artifacttrait {
        public int id { get; set; }
        public int rank { get; set; }
    }

    public class Relic {
        public int socket { get; set; }
        public int itemId { get; set; }
        public int context { get; set; }
        public int[] bonusLists { get; set; }
    }

    public class Offhand {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int quality { get; set; }
        public int itemLevel { get; set; }
        public Tooltipparams16 tooltipParams { get; set; }
        public Stat15[] stats { get; set; }
        public int armor { get; set; }
        public Weaponinfo1 weaponInfo { get; set; }
        public string context { get; set; }
        public object[] bonusLists { get; set; }
        public int artifactId { get; set; }
        public int displayInfoId { get; set; }
        public int artifactAppearanceId { get; set; }
        public object[] artifactTraits { get; set; }
        public object[] relics { get; set; }
        public Appearance16 appearance { get; set; }
    }

    public class Tooltipparams16 {
        public int timewalkerLevel { get; set; }
    }

    public class Weaponinfo1 {
        public Damage1 damage { get; set; }
        public float weaponSpeed { get; set; }
        public float dps { get; set; }
    }

    public class Damage1 {
        public int min { get; set; }
        public int max { get; set; }
        public float exactMin { get; set; }
        public float exactMax { get; set; }
    }

    public class Appearance16 {
        public int itemAppearanceModId { get; set; }
    }

    public class Stat15 {
        public int stat { get; set; }
        public int amount { get; set; }
    }

    public class Stats {
        public int health { get; set; }
        public string powerType { get; set; }
        public int power { get; set; }
        public int str { get; set; }
        public int agi { get; set; }
        public int intellect { get; set; }
        public int sta { get; set; }
        public float speedRating { get; set; }
        public float speedRatingBonus { get; set; }
        public float crit { get; set; }
        public int critRating { get; set; }
        public float haste { get; set; }
        public int hasteRating { get; set; }
        public float hasteRatingPercent { get; set; }
        public float mastery { get; set; }
        public int masteryRating { get; set; }
        public float leech { get; set; }
        public float leechRating { get; set; }
        public float leechRatingBonus { get; set; }
        public int versatility { get; set; }
        public float versatilityDamageDoneBonus { get; set; }
        public float versatilityHealingDoneBonus { get; set; }
        public float versatilityDamageTakenBonus { get; set; }
        public float avoidanceRating { get; set; }
        public float avoidanceRatingBonus { get; set; }
        public int spellPen { get; set; }
        public float spellCrit { get; set; }
        public int spellCritRating { get; set; }
        public float mana5 { get; set; }
        public float mana5Combat { get; set; }
        public int armor { get; set; }
        public float dodge { get; set; }
        public int dodgeRating { get; set; }
        public float parry { get; set; }
        public int parryRating { get; set; }
        public float block { get; set; }
        public int blockRating { get; set; }
        public float mainHandDmgMin { get; set; }
        public float mainHandDmgMax { get; set; }
        public float mainHandSpeed { get; set; }
        public float mainHandDps { get; set; }
        public float offHandDmgMin { get; set; }
        public float offHandDmgMax { get; set; }
        public float offHandSpeed { get; set; }
        public float offHandDps { get; set; }
        public float rangedDmgMin { get; set; }
        public float rangedDmgMax { get; set; }
        public float rangedSpeed { get; set; }
        public float rangedDps { get; set; }
    }

    public class Progression {
        public Raid[] raids { get; set; }
    }

    public class Raid {
        public string name { get; set; }
        public int lfr { get; set; }
        public int normal { get; set; }
        public int heroic { get; set; }
        public int mythic { get; set; }
        public int id { get; set; }
        public Boss[] bosses { get; set; }
    }

    public class Boss {
        public int id { get; set; }
        public string name { get; set; }
        public int normalKills { get; set; }
        public long normalTimestamp { get; set; }
        public int heroicKills { get; set; }
        public long heroicTimestamp { get; set; }
        public int lfrKills { get; set; }
        public long lfrTimestamp { get; set; }
        public int mythicKills { get; set; }
        public long mythicTimestamp { get; set; }
    }

    public class Talent {
        public bool selected { get; set; }
        public Talent1[] talents { get; set; }
        public Spec spec { get; set; }
        public string calcTalent { get; set; }
        public string calcSpec { get; set; }
    }

    public class Spec {
        public string name { get; set; }
        public string role { get; set; }
        public string backgroundImage { get; set; }
        public string icon { get; set; }
        public string description { get; set; }
        public int order { get; set; }
    }

    public class Talent1 {
        public int tier { get; set; }
        public int column { get; set; }
        public Spell spell { get; set; }
        public Spec1 spec { get; set; }
    }

    public class Spell {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string description { get; set; }
        public string castTime { get; set; }
        public string range { get; set; }
        public string cooldown { get; set; }
        public string powerCost { get; set; }
    }

    public class Spec1 {
        public string name { get; set; }
        public string role { get; set; }
        public string backgroundImage { get; set; }
        public string icon { get; set; }
        public string description { get; set; }
        public int order { get; set; }
    }

}