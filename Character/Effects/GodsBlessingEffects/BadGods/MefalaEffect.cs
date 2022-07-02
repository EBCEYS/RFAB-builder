using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class MefalaEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Мефала";
        public string Description { get; set; } = "+2х/+1х к модификатору скрытной атаки для оружия ближнего и дальнего боя. Атаки оружием поглощают 25 ХП цели. +25% силы и длительности ядов.";
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
                character.SneakAttackMultiplierMelee += 2.0;
                character.SneakAttackMultiplierRange += 1.0;

                character.PoisonPowerAndDuration += 0.25;
            }
        }
    }
}
