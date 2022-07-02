using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class ServantOfKynarethEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Служитель Кинарет";
        public string Description { get; set; } = "10% снижения урона от животных. 50% СТ регена.";
        public PassiveEffectType Type { get; set; } = PassiveEffectType.BlessingOfNature;
        public int? PowerLevel { get; set; } = 1;
        public Color Color { get; set; } = Color.Green;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.BeastResistance += 0.1;
            character.STRegenPercents += 0.5;
        }
    }
}
