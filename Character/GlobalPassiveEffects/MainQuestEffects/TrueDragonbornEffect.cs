using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class TrueDragonbornEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Истинный Драконорожденный";
        public string Description { get; set; } = "10% длительности криков. 10% урона криков. 10% эффективности криков.";
        public PassiveEffectType Type { get; set; } = PassiveEffectType.MainStory;
        public int? PowerLevel { get; set; } = 1;
        public Color Color { get; set; } = Color.Blue;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.ShoutsEffect += 0.1;
            character.ShoutsDamageMultiplier += 0.1;
        }
    }
}
