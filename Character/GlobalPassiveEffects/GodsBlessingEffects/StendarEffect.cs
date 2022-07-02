using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class StendarEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Стендар";
        public string Description { get; set; } = "15% скорости передвижения. 15% скорости атаки. 15% урона по нежити и даэдра.";
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
                character.MovementSpeed += 0.15;
                character.AttackSpeed += 0.15;
                character.UndeadDamage += 0.15;
            }
        }
    }
}
