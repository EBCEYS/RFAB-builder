using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class TalosEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Талос";
        public string Description { get; set; } = "20% снижение длительности перезарядки криков. 10% урона и эффективности криков. 35% сопротивления электричеству.";
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
                character.ShoutsCooldownRecovery += 0.2;
                character.ShoutsDamageMultiplier += 0.1;
                character.ShoutsEffect += 0.1;
                character.LightningResistance += 0.35;
            }
        }
    }
}
