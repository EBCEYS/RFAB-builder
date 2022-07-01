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

        public static IBaseRace GetRaceFromList(RacesTypes race)
        {
            return Races.Find(x => x.RaceType == race);
        }
    }
}
