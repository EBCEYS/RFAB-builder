using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class KinaretEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Кинарет";
        public string Description { get; set; } = "50% сопротивления ядам и иммунитет к падению. 1 ХП/СТ/МП регена. 15% урона копьями, луками и арбалетами.";
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
                //TODO: добавить проверку на случай эквипнутого копья/лука/арбалета.
                character.PoisonResistance += 0.5;
                character.FallDamage = 0.0;
                character.HPRegenDigit += 1.0;
                character.MPRegenDigit += 1.0;
                character.STRegenDigit += 1.0;

            }
        }
    }
}
