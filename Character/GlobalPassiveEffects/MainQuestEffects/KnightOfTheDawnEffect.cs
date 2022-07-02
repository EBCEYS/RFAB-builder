using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class KnightOfTheDawnEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Рыцари Зари";
        public string Description { get; set; } = "10% урона по любой нежити. 10% снижение стоимости заклинаний школы восстановления.";
        public PassiveEffectType Type { get; set; } = PassiveEffectType.MainStory;
        public int? PowerLevel { get; set; } = 1;
        public Color Color { get; set; } = Color.Blue;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.UndeadDamage += 0.1;
            character.RestoreCost -= 0.1;
        }
    }
}
