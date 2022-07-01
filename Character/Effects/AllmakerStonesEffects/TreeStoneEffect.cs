using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class TreeStoneEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Камень Дерева";
        public string Description { get; set; } = "+10% сопротивления магии. +20% сопротивления ядам. -20% сопротивления огню.";
        public PassiveEffectType Type { get; set; } = PassiveEffectType.AllMakerStone;
        public int? PowerLevel { get; set; } = 1;
        public Color Color { get; set; } = Color.Teal;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.MageResistance += 0.1;
            character.PoisonResistance += 0.2;
            character.FireResistance -= 0.2;
        }
    }
}
