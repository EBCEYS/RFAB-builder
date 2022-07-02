using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class ArkeyEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Аркей";
        public string Description { get; set; } = "100 брони. 15 к навыку восстановления. 35% сопротивления холоду.";
        public PassiveEffectType Type { get; set; } = PassiveEffectType.GodBlessing;
        public int? PowerLevel { get; set; } = 1;
        public Color Color { get; set; } = Color.Purple;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            if (character.IsGood)
            {
                character.ArmourClass += 100;
                character.Restoration += 15;
                character.ColdResistance += 0.35;
            }
        }
    }
}
