using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class AkatowEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Акатош";
        public string Description { get; set; } = "50 СТ [ранг 1]. 35% сопротивления огню. 10% снижения входящего урона откриков.";
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
                character.BlueStamina += 50;
                character.FireResistance += 0.35;
                character.ShoutsDamageReduction += 0.1;
            }
        }
    }
}
