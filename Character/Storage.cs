using RFAB_builder.Character.Effects;
using RFAB_builder.Character.Races;
using RFAB_builder.Character.Stones;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RFAB_builder.Character
{
    static class Storage
    {
        public static List<IBaseRace> Races { get; set; } = new List<IBaseRace>()
        {
            new Ork(), new Nord(), new Redgard()
            , new Kadjit(), new Bosmer()
            , new Altmer(), new Bretonec()
            , new Danmer(), new Imperec(), new Argonianin()
        };
        public static List<IBaseStone> Stones { get; set; } = new List<IBaseStone>()
        {
            new WarriorStone(), new LedyStone(), new LordeStone(), new TowerStone(), new HorseStone(),
            new ThiefStone(), new LoverStone(), new ShadowStone(), new SnakeStone(),
            new MageStone(), new ShcolarStone(), new AtronahStone(), new RitualStone()
        };

        public static List<IBasePassiveEffect> MainQuestEffects { get; set; } = new List<IBasePassiveEffect>()
        {
            new AlduinsDoomEffect(), new KnightOfTheDawnEffect(), new LordOfClanVolkiharEffect(), new TrueDragonbornEffect()
        };
        public static List<IBasePassiveEffect> BlessingOfNatureEffects { get; set; } = new List<IBasePassiveEffect>()
        {
            new ServantOfKynarethEffect(), new ZealotKynarethEffect()
        };
        public static List<IBasePassiveEffect> GuildsEffects { get; set; } = new List<IBasePassiveEffect>()
        {
            new HarbingerEffect(), new ArchmageEffect(), new ThiefMasterEffect()
            , new HearingOneEffect(), new SecretAgentEffect(), new TheGiftOfTalkativenessEffect()
        };
        public static List<IBasePassiveEffect> CivilWarEffects { get; set; } = new List<IBasePassiveEffect>()
        {
            new LegateEffect(), new HeraldOfTheStormEffect()
        };
        public static List<IBasePassiveEffect> BlackBooksIllRegentEffects { get; set; } = new List<IBasePassiveEffect>()
        {
            new SeakerOfPowerEffect(), new SeakerOfMagicEffect(), new SeakerOfShadowsEffect()
        };
        public static List<IBasePassiveEffect> BlackBooksWindsOfChangeEffects { get; set; } = new List<IBasePassiveEffect>()
        {
            new ScientistsIntuitionEffect(), new LoverIntuitionEffect(), new CompanionsIntuitionEffect()
        };
        public static IBasePassiveEffect UntelledLegendsEffects { get; set; } = new BardsKnowledgeEffect();
        public static List<IBasePassiveEffect> AllMakerStonesEffects { get; set; } = new List<IBasePassiveEffect>()
        {
            new EarthStoneEffect(), new TreeStoneEffect(), new BeastStoneEffect()
            , new WaterStoneEffect(), new WindStoneEffect(), new SunStoneEffect()
        };
        public static List<IBasePassiveEffect> AnotherEffects { get; set; } = new List<IBasePassiveEffect>()
        {
            new OgmaInfinumEffect(), new ElderKnowledgesEffect(), new SkyesEyeEffect(), new KarghstagSpiritEffect()
            , new AlikhrsDisciplineEffect(), new ArenaLegendEffect(), new EsbernPotionEffect(), new DebellaChosenEffect()
            , new MaraChosenEffect()
        };
    }
}
