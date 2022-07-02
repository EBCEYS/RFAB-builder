using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class AlduinsDoomEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Погибель Алдуина";
        public string Description { get; set; } = "10% урона по драконам. 10% снижения урона от драконов.";
        public PassiveEffectType Type { get; set; } = PassiveEffectType.MainStory;
        public int? PowerLevel { get; set; } = 1;
        public Color Color { get; set; } = Color.Blue;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.DragonsDamage += 0.1;
            character.DragonResistance += 0.1;
        }
    }
}
