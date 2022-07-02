using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class MalakatEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Малакат";
        public string Description { get; set; } = "100/200 брони. 15/30% устойчивости. Остальные эффекты не реализованы!";
        public PassiveEffectType Type { get; set; } = PassiveEffectType.GodBlessing;
        public int? PowerLevel { get; set; } = 1;
        public Color Color { get; set; } = Color.Purple;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            if (PowerLevel == 1)
            {
                character.ArmourClass += 100;
                character.Stability += 0.15;
            }
            else
            {
                character.ArmourClass += 200;
                character.Stability += 0.3;
            }
        }
    }
}
