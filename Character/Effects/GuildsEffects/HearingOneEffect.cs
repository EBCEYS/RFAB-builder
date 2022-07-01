using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class HearingOneEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Слышаший";
        public string Description { get; set; } = "30 мастерства одноручному и стрелковому оружию [только в режиме скрытности]. 10% скрытности. 10% бесшумности.";
        public PassiveEffectType Type { get; set; } = PassiveEffectType.Guilds;
        public int? PowerLevel { get; set; } = 1;
        public Color Color { get; set; } = Color.Red;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            if (character.IsInStealth)
            {
                character.OneHandedMastery += 30;
                character.ArcheryMastery += 30;
            }
            character.SneakMastery += 0.1;
            character.MovementNoise -= 0.1;
        }
    }
}
