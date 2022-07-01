using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class ArchmageEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Архимаг";
        public string Description { get; set; } = "30 МП [ранг I]. 50% МП регена. 5% сопротивления магии. Персонаж изучает заклинание «Триумвират Стихий»";
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
            character.MPRegenPercents += 0.5;
            character.MageResistance += 0.05;
        }
    }
}
