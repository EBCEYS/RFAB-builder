using RFAB_builder.Character.Races;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character
{
    static class Storage
    {
        public static List<IBaseRace> Races { get; set; } = new List<IBaseRace>() { new Ork(), new Nord(), new Redgard()
        , new Kadjit(), new Bosmer(), new Altmer(), new Bretonec(), new Danmer(), new Imperec(), new Argonianin() };

        public static IBaseRace GetRaceFromList(RacesTypes race)
        {
            switch(race)
            {
                case RacesTypes.Ork: return Races[0];
                case RacesTypes.Nord: return Races[1];
                case RacesTypes.Redgard: return Races[2];
                case RacesTypes.Kadjit: return Races[3];
                case RacesTypes.Bosmer: return Races[4];
                case RacesTypes.Altmer: return Races[5];
                case RacesTypes.Bretonec: return Races[6];
                case RacesTypes.Danmer: return Races[7];
                case RacesTypes.Imperec: return Races[8];
                case RacesTypes.Argonianin: return Races[9];
                default: return Races.FirstOrDefault();
            }
        }
    }

    public enum RacesTypes
    {
        Ork,
        Nord,
        Redgard,
        Kadjit,
        Bosmer,
        Altmer,
        Bretonec,
        Danmer,
        Imperec,
        Argonianin
    }
}
