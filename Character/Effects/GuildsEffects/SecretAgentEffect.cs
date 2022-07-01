using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class SecretAgentEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Тайный агент";
        public string Description { get; set; } = "30% шанс избежать 10% получаемого урона [любого]. 10% сопротивления ядам.";
        public PassiveEffectType Type { get; set; }
        public int? PowerLevel { get; set; }
        public Color Color { get; set; }

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.PhysicalDamageReduction += 0.03;
            character.PoisonResistance += 0.1;
        }
    }
}
