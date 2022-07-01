using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class ArenaLegendEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Легенда Арены";
        public string Description { get; set; } = "+10% бонуса к торговле. Убеждения и запугивания стали значительно эффективнее. +10 ХП | МП | СТ [ранг 1]. +30% устойчивости.";
        public PassiveEffectType Type { get; set; } = PassiveEffectType.Another;
        public int? PowerLevel { get; set; } = 1;
        public Color Color { get; set; } = Color.Yellow;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.Trade += 0.1;
            character.BlueHP += 10;
            character.BlueMana += 10;
            character.BlueStamina += 10;
            character.Stability += 0.3;
        }
    }
}
