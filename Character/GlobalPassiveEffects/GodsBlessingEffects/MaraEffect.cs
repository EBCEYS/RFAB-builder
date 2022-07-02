using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class MaraEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Мара";
        public string Description { get; set; } = "15% снижение стоимости заклинаний восстановления. 100% сопротивления болезням и иммунитет к любому параличу. 500% ХП регена.";
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
                character.RestoreCost -= 0.15;
                character.IllResistance += 1.0;
                character.HPRegenPercents += 5.0;
            }
        }
    }
}
