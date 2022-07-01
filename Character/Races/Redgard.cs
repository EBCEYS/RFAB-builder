using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Races
{
    internal class Redgard : IBaseRace
    {
        public string Name { get; set; } = "Редгард";
        public string Description { get; set; } = "10% скорости атаки любым оружием. 20 мастерства оружию ближнего и дальнего боя. Имунитет к параличу. 50% сопротивления ядам. 50% сопротивления болезням. 20% снижение стоимости силовых атак.";
        public long BaseHP { get; set; } = 110;
        public long BaseMP { get; set; } = 70;
        public long BaseST { get; set; } = 120;
        public double BaseHPRegen { get; set; } = 0.0;
        public double BaseMPRegen { get; set; } = 0.01;
        public double BaseSTRegen { get; set; } = 0.0165;
        public long BaseUnarmedDamage { get; set; } = 8;
        public long BaseWeight { get; set; } = 130;

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

            character.AttackSpeed += 0.1;
            character.OneHandedMastery += 20;
            character.ArcheryMastery += 20;
            character.PoisonResistance += 0.5;
            character.IllResistance += 0.5;
            character.ReduceCostOfPowerAttacks -= 0.2;

            character.OneHandedWeapon += 15;
            character.TwoHandedWeapon += 5;
            character.UnarmedFight += 5;
            character.Block += 5;
            character.Smithing += 5;
            character.Evasion += 5;
        }
    }
}
