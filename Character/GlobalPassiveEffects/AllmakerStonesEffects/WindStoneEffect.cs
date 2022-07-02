using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class WindStoneEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Камень Ветра";
        public string Description { get; set; } = "+10% скорости атаки. +10% скорости передвижения. -100 брони.";
        public PassiveEffectType Type { get; set; } = PassiveEffectType.AllMakerStone;
        public int? PowerLevel { get; set; } = 1;
        public Color Color { get; set; } = Color.Teal;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.AttackSpeed += 0.1;
            character.MovementSpeed += 0.1;
            character.ArmourClass -= 100;
        }
    }
}
