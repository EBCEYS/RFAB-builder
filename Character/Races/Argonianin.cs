using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Races
{
    internal class Argonianin : IBaseRace
    {
        public string Name { get; set; } = "Аргониани";
        public string Description { get; set; } = "х1.5 ХП регенирации. +1% ХП регенерации. Дополнительная регенерация ХП в воде. +50% СТ регенерации. +75% сопротивления ядам. +50% скорости плавания в воде. Водное дыхание. Алхимия без перка. Скрытность без перка. Крепкий желудок.";
        public long BaseHP { get; set; } = 110;
        public long BaseMP { get; set; } = 90;
        public long BaseST { get; set; } = 120;
        public double BaseHPRegen { get; set; } = 0.0;
        public double BaseMPRegen { get; set; } = 0.011;
        public double BaseSTRegen { get; set; } = 0.016;
        public long BaseUnarmedDamage { get; set; } = 10;
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

            character.HPRegenMultiplyer += 1.5;
            character.HPRegenPercents += 1.0;
            character.STRegenPercents += 0.5;
            character.PoisonResistance += 0.75;
            character.IllResistance += 0.75;

            character.Evasion += 10;
            character.Sneak += 10;
            character.UnarmedDamage += 5;
            character.Alteration += 5;
            character.ArtOfTheRogue += 5;
            character.Alchemy += 5;
        }
    }
}
