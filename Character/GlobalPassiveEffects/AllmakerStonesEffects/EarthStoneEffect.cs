using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class EarthStoneEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Камень Земли";
        public string Description { get; set; } = "+50 СТ [ранг 1]. +100 брони. -10% скорости передвижения.";
        public PassiveEffectType Type { get; set; } = PassiveEffectType.AllMakerStone;
        public int? PowerLevel { get; set; } = 1;
        public Color Color { get; set; } = Color.Teal;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.BlueStamina += 50;
            character.ArmourClass += 100;
            character.MovementSpeed -= 0.1;
        }
    }
}
