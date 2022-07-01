using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class SeakerOfMagicEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Искатель волшебства";
        public string Description { get; set; } = "10% снижение стоимости всех заклинаний. 20% дальности всех заклинаний.";
        public PassiveEffectType Type { get; set; } = PassiveEffectType.BlackBooks;
        public int? PowerLevel { get; set; } = 1;
        public Color Color { get; set; } = Color.Gray;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.DestrCost -= 0.1;
            character.RestoreCost -= 0.1;
            character.AlterationCost -= 0.1;
            character.ConjurCost -= 0.1;
            character.IllusionCost -= 0.1;
        }
    }
}
