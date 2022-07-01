using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class MaraChosenEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Избранник Мары";
        public string Description { get; set; } = "-10% стоимости заклинаний школы восстановления.";
        public PassiveEffectType Type { get; set; } = PassiveEffectType.Another;
        public int? PowerLevel { get; set; } = 1;
        public Color Color { get; set; } = Color.Yellow;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.RestoreCost -= 0.1;
        }
    }
}
