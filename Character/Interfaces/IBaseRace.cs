using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character
{
    public interface IBaseRace
    {
        string Name { get; set; }
        void Effect();
        string Description { get; set; }
        void Effect(Characters character);
        long BaseHP { get; set; }
        long BaseMP { get; set; }
        long BaseST { get; set; }

        double BaseHPRegen { get; set; }
        double BaseMPRegen { get; set; }
        double BaseSTRegen { get; set; }

        long BaseUnarmedDamage { get; set; }
        long BaseWeight { get; set; }

        RacesTypes RaceType { get; set; }
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
