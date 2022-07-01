using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class HarbingerEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Предвестник";
        public string Description { get; set; } = "30 ХП [ранг I]. 250% ХП регена. 3 ХП регена союзникам[радиус 100]. Спутники становятся более смелыми в бою рядом с вами.";
        public PassiveEffectType Type { get; set; } = PassiveEffectType.Guilds;
        public int? PowerLevel { get; set; } = 1;
        public Color Color { get; set; } = Color.Red;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.BlueHP += 30;
            character.HPRegenPercents += 2.5;
        }
    }
}
