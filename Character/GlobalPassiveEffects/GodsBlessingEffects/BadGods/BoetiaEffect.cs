using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class BoetiaEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Боэтия";
        public string Description { get; set; } = "15% урона любым оружием. 40 мастерства любым оружием. 10% скорости передвижения";
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
                character.ArcheryDamageMultiplier += 0.15;
                character.OneHandedDamageMultiplier += 0.15;
                character.TwoHandedDamageMultiplier += 0.15;

                character.ArcheryMastery += 40;
                character.OneHandedMastery += 40;
                character.TwoHandedMastery += 40;

                character.MovementSpeed += 0.1;
            }
        }
    }
}
