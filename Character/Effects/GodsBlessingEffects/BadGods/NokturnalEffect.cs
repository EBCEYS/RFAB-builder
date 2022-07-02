using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class NokturnalEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Ноктюрнал";
        public string Description { get; set; } = "10/25 срытности. 10/25% бесшумности. 2/4 МП регена.";
        public PassiveEffectType Type { get; set; } = PassiveEffectType.GodBlessing;
        public int? PowerLevel { get; set; } = 1;
        public Color Color { get; set; } = Color.Purple;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            if (!character.IsGood)
            {
                if (PowerLevel == 1)
                {
                    character.SneakMastery += 10;
                    character.MovementNoise -= 0.1;
                    character.MPRegenDigit += 2.0;
                }
                else
                {
                    character.SneakMastery += 25;
                    character.MovementNoise -= 0.25;
                    character.MPRegenDigit += 4.0;
                }
            }
        }
    }
}
