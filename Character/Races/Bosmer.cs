using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Races
{
    internal class Bosmer : IBaseRace
    {
        public string Name { get; set; } = "Босмер (лесной эльф)";
        public string Description { get; set; } = "50% сопротивления болезням. Пассивная способность \"Воин Валенвуда\", которая дает 15% увеличения физического урона по животным и 15% снижение входящего физического урона от животных. Активная способность \"Подчинение животного\", которая позволяет приручать животных, делая их своими спутниками. Животные имеют уникальные ауры и прокачиваются вместе с персонажем, а их сила зависит от уровня игрока. Алихимия без перка. Скрытность без перка. Крепкий желудок.";
        public long BaseHP { get; set; } = 90;
        public long BaseMP { get; set; } = 110;
        public long BaseST { get; set; } = 120;
        public double BaseHPRegen { get; set; } = 0.0;
        public double BaseMPRegen { get; set; } = 0.011;
        public double BaseSTRegen { get; set; } = 0.0165;
        public long BaseUnarmedDamage { get; set; } = 5;
        public long BaseWeight { get; set; } = 110;

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

            character.IllResistance += 0.5;
            character.BeastsDamage += 0.15;
            character.BeastResistance += 0.15;

            character.Archery += 15;
            character.Evasion += 5;
            character.UnarmedFight += 5;
            character.ArtOfTheRogue += 5;
            character.Alchemy += 5;
            character.Sneak += 5;
        }
    }
}
