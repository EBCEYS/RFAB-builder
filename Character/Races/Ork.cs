using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Races
{
    internal class Ork : IBaseRace
    {
        public string Name { get; set; } = "Орк";
        public string Description { get; set; } = @"Воин.5/10/15/20/25/30% снижение входящего физического, стихийного и урона от кровотечения [оверкап] при 100-91/90-81/80-71/70-61/60-51/50-0% текущего здоровья. 35% снижения стоимости силовых атак. Крепкий желудок.";
        public long BaseHP { get; set; } = 130;
        public long BaseMP { get; set; } = 60;
        public long BaseST { get; set; } = 110;
        public double BaseHPRegen { get; set; } = 0.0;
        public double BaseMPRegen { get; set; } = 0.01;
        public double BaseSTRegen { get; set; } = 0.017;
        public long BaseUnarmedDamage { get; set; } = 10;
        public long BaseWeight { get; set; } = 150;
        public RacesTypes RaceType { get; set; } = RacesTypes.Ork;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.WhiteHP += BaseHP;
            character.WhiteMana += BaseMP;
            character.WhiteStamina += BaseST;
            character.HPRegenPercents += BaseHPRegen;
            character.MPRegenPercents += BaseMPRegen;
            character.STRegenPercents += BaseSTRegen;
            character.UnarmedDamage += BaseUnarmedDamage;
            character.Weight += BaseWeight;
            character.ReduceCostOfPowerAttacks -= 0.35;
            character.HeavyArmour += 15;
            character.OneHandedWeapon += 5;
            character.TwoHandedWeapon += 5;
            character.Block += 5;
            character.Smithing += 5;
            character.Evasion += 5;
        }
    }
}
