using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    /// <summary>
    /// Хрен его знает как это правильно переводится на английский. Лень гуглить.
    /// </summary>
    public class AlikhrsDisciplineEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Алик\'рская Дисциплина";
        public string Description { get; set; } = "+10% сопротивления ядам. +5% сопротивления огню.";
        public PassiveEffectType Type { get; set; } = PassiveEffectType.Another;
        public int? PowerLevel { get; set; } = 1;
        public Color Color { get; set; } = Color.Yellow;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.PoisonResistance += 0.1;
            character.FireResistance += 0.05;
        }
    }
}
