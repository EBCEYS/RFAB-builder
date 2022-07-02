using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class AurielEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Ауриэль";
        public string Description { get; set; } = "15% урона серебрянным оружием. 40% эффективности блока. Аура с радиусом 40, воздействующая на враждебную нежить (см. библиотеку).";
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
                //TODO:Сделать все что связяно с этими эффектами.
            }
        }
    }
}
