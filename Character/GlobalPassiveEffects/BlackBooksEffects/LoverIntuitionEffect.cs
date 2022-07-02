using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class LoverIntuitionEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Интуиция любовника";
        public string Description { get; set; } = "+10% снижения длительности перезарядки криков.";
        public PassiveEffectType Type { get; set; } = PassiveEffectType.BlackBooks;
        public int? PowerLevel { get; set; } = 1;
        public Color Color { get; set; } = Color.Gray;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.ShoutsCooldownRecovery += 0.1;
        }
    }
}
