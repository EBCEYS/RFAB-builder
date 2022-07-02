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
        public static List<IBasePassiveEffect> BlackBooksEffects { get; set; } = new List<IBasePassiveEffect>()
        {
            new SeakerOfPowerEffect(), new SeakerOfMagicEffect(), new SeakerOfShadowsEffect()
            , new ScientistsIntuitionEffect(), new LoverIntuitionEffect(), new CompanionsIntuitionEffect()
            , new BardsKnowledgeEffect()
        };
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
        public static List<IBasePassiveEffect> GoodGodsEffects { get; set; } = new List<IBasePassiveEffect>()
        {
            new AkatowEffect(), new ZenitarEffect(), new DjulianosEffect(), new DibellaEffect()
            , new KinaretEffect(), new MaraEffect(), new ArkeyEffect(), new StendarEffect()
            , new TalosEffect(), new AurielEffect()
        };
        public static List<IBasePassiveEffect> BadGodsEffects { get; set; } = new List<IBasePassiveEffect>()
        {
            new BoetiaEffect(), new NokturnalEffect(), new MefalaEffect()
        };
        public static List<IBasePassiveEffect> NeutralGodsEffects { get; set; } = new List<IBasePassiveEffect>()
        {
            new PeriaitEffect(), new SangvinEffect(), new MalakatEffect(), new AzuraEffect()
        };
    }
}
