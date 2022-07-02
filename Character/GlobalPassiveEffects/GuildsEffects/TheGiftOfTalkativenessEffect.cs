using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class TheGiftOfTalkativenessEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Дар разговорчивости";
        public string Description { get; set; } = "10 навыка Искусство мошенника.";
        public PassiveEffectType Type { get; set; } = PassiveEffectType.Guilds;
        public int? PowerLevel { get; set; } = 1;
        public Color Color { get; set; } = Color.Red;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.ArtOfTheRogue += 10;
        }
    }
}
