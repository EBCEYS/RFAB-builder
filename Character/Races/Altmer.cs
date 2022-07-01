using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Races
{
    internal class Altmer : IBaseRace
    {
        public string Name { get; set; } = "Альтмер";
        public string Description { get; set; } = "Пассивная способность \"Резонанс чар\", которая повышает эффективность и расход чар оружия [НЕ кровотечения] в полнотора раза [работает и на стихийные стрелы/болты]. 50 МП. 1 МП реген. 50% сопротивления болезням. 5 к навыку всех школ магии. 5% снижения стоимости всех заклинаний. 15% увеличение длительности всех заклинаний. Зачарование без перка. 20% снижения сопротивления магии.";
        public long BaseHP { get; set; } = 90;
        public long BaseMP { get; set; } = 130;
        public long BaseST { get; set; } = 80;
        public double BaseHPRegen { get; set; } = 0.0;
        public double BaseMPRegen { get; set; } = 0.02;
        public double BaseSTRegen { get; set; } = 0.015;
        public long BaseUnarmedDamage { get; set; } = 5;
        public long BaseWeight { get; set; } = 100;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Character character)
        {
            character.WhiteHP += BaseHP;
            character.WhiteMana += BaseMP + 50;
            character.WhiteStamina += BaseST;
            character.HPRegenPercents += BaseHPRegen;
            character.MPRegenPercents += BaseMPRegen;
            character.STRegenPercents += BaseSTRegen;
            character.UnarmedDamage += BaseUnarmedDamage;
            character.Weight += BaseWeight;

            character.MPRegenDigit += 1.0;
            character.IllResistance += 0.5;
            character.MageResistance -= 0.2;

            character.AlterationCost -= 0.05;
            character.ConjurCost -= 0.05;
            character.DestrCost -= 0.05;
            character.RestoreCost -= 0.05;
            character.IllusionCost -= 0.05;

            character.Illusion += 15;
            character.Destruction += 15;
            character.Alteration += 10;
            character.Restoration += 10;
            character.Conjuration += 10;
            character.Enchanting += 10;
        }
    }
}
