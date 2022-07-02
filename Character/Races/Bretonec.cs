using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Races
{
    internal class Bretonec : IBaseRace
    {
        public string Name { get; set; } = "Бретонец";
        public string Description { get; set; } = "10% сопротивления магии. 15% поглощения магии. Увеличение предела снижения стоимости всех заклинаний с 60% до 70%. Зачарование без перка. Алхимия без перка.";
        public long BaseHP { get; set; } = 90;
        public long BaseMP { get; set; } = 120;
        public long BaseST { get; set; } = 90;
        public double BaseHPRegen { get; set; } = 0.0;
        public double BaseMPRegen { get; set; } = 1.7;
        public double BaseSTRegen { get; set; } = 1.5;
        public long BaseUnarmedDamage { get; set; } = 7;
        public long BaseWeight { get; set; } = 100;
        public RacesTypes RaceType { get; set; } = RacesTypes.Bretonec;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.WhiteHP += BaseHP;
            character.WhiteMana += BaseMP;
            character.WhiteStamina += BaseST;
            character.HPRegenMultiplyer += BaseHPRegen;
            character.MPRegenMultiplyer += BaseMPRegen;
            character.STRegenMultiplyer += BaseSTRegen;
            character.UnarmedDamage += BaseUnarmedDamage;
            character.Weight += BaseWeight;

            character.MageResistance += 0.1;
            character.ChanceToAbsorbSpell += 0.15;
            character.MageCostReduceCup += 0.1;

            character.Conjuration += 15;
            character.Alteration += 5;
            character.Illusion += 5;
            character.Restoration += 5;
            character.Enchanting += 5;
            character.Alchemy += 5;
        }
    }
}
