using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Races
{
    internal class Imperec : IBaseRace
    {
        public string Name { get; set; } = "Имперец";
        public string Description { get; set; } = "10% увеличения опыта. 10% торговли. Втроенный перк \"Торговец\". 50 СТ [ранг 1]. 1 СТ регена во время бега. 2 СТ регена во время спринта. 20% снижение стоимости силовых атак.";
        public long BaseHP { get; set; } = 110;
        public long BaseMP { get; set; } = 100;
        public long BaseST { get; set; } = 110;
        public double BaseHPRegen { get; set; } = 0.0;
        public double BaseMPRegen { get; set; } = 0.011;
        public double BaseSTRegen { get; set; } = 0.019;
        public long BaseUnarmedDamage { get; set; } = 8;
        public long BaseWeight { get; set; } = 120;
        public RacesTypes RaceType { get; set; } = RacesTypes.Imperec;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.WhiteHP += BaseHP;
            character.WhiteMana += BaseMP;
            character.WhiteStamina += BaseST + 50;
            character.HPRegenPercents += BaseHPRegen;
            character.MPRegenPercents += BaseMPRegen;
            character.STRegenPercents += BaseSTRegen;
            character.UnarmedDamage += BaseUnarmedDamage;
            character.Weight += BaseWeight;

            character.Trade += 0.1;
            character.ReduceCostOfPowerAttacks += 0.2;

            character.Speech += 10;
            character.Restoration += 10;
            character.OneHandedWeapon += 5;
            character.Block += 5;
            character.HeavyArmour += 5;
            character.Alteration += 5;
        }
    }
}
