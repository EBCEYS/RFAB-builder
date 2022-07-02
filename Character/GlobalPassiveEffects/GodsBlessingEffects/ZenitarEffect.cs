using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class ZenitarEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Зенитар";
        public string Description { get; set; } = "50 ХП [ранг 1]. 100% СТ реген. 10% бонус к продажам и покупкам.";
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
                character.BlueHP += 50;
                character.STRegenPercents += 1.0;
                character.Trade += 0.1;
            }
        }
    }
}
