using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class BardsKnowledgeEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Знание барда.";
        public string Description { get; set; } = "+50 СТ. +10% скорости передвижения";
        public PassiveEffectType Type { get; set; } = PassiveEffectType.BlackBooks;
        public int? PowerLevel { get; set; } = 1;
        public Color Color { get; set; } = Color.Gray;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.BlueStamina += 50;
            character.MovementSpeed += 0.1;
        }
    }
}
