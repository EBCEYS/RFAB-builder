using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Races
{
    internal class Danmer : IBaseRace
    {
        public string Name { get; set; } = "Данмер";
        public string Description { get; set; } = "50% сопротивления огню. 10% снижения стоимости заклинаний разрушения. 10% увелничение длительности заклинаний разрушения. 15% снижения стоимости силовых атак. Зачарование без перка. Алхимия без перка. Скрытность без перка.";
        public long BaseHP { get; set; } = 100;
        public long BaseMP { get; set; } = 100;
        public long BaseST { get; set; } = 100;
        public double BaseHPRegen { get; set; } = 0.0;
        public double BaseMPRegen { get; set; } = 0.014;
        public double BaseSTRegen { get; set; } = 0.016;
        public long BaseUnarmedDamage { get; set; } = 8;
        public long BaseWeight { get; set; } = 120;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Character character)
        {
            character.WhiteHP += BaseHP;
            character.WhiteMana += BaseMP;
            character.WhiteStamina += BaseST;
            character.HPRegenPercents += BaseHPRegen;
            character.MPRegenPercents += BaseMPRegen;
            character.STRegenPercents += BaseSTRegen;
            character.UnarmedDamage += BaseUnarmedDamage;
            character.Weight += BaseWeight;

            character.FireResistance += 0.5;
            character.DestrCost -= 0.1;
            character.ReduceCostOfPowerAttacks -= 0.15;

            character.Destruction += 10;
            character.OneHandedWeapon += 10;
            character.Evasion += 5;
            character.Sneak += 5;
            character.Enchanting += 5;
            character.Alchemy += 5;
        }
    }
}
