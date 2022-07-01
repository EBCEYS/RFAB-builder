using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class OgmaInfinumEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Огма Инфинум";
        public string Description { get; set; } = "+ 30 ХП | МП | СТ [ранг 1] [белые характеристики] [на выбор]";
        public PassiveEffectType Type { get; set; } = PassiveEffectType.Another;
        public int? PowerLevel { get; set; } = 1;
        public Color Color { get; set; } = Color.Yellow;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            switch(PowerLevel)
            {
                case 1: character.WhiteHP += 30; break;
                case 2: character.WhiteMana += 30; break;
                default: character.WhiteStamina += 30; break;
            }
            character.MaxPerksCount += 1;
        }
    }
}
