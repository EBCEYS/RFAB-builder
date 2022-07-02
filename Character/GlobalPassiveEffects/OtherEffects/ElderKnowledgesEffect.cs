using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class ElderKnowledgesEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Древние знания";
        public string Description { get; set; } = "+10% рейтинг двемерской брони.";
        public PassiveEffectType Type { get; set; } = PassiveEffectType.Another;
        public int? PowerLevel { get; set; } = 1;
        public Color Color { get; set; } = Color.Yellow;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            if (character.BodyArmour?.ItemType == ItemType.DvemerikArmor)
            {
                character.BodyArmour.ClassMultiplier += 0.1;
            }
            if (character.Head?.ItemType == ItemType.DvemerikArmor)
            {
                character.Head.ClassMultiplier += 0.1;
            }
            if (character.Gloves?.ItemType == ItemType.DvemerikArmor)
            {
                character.Gloves.ClassMultiplier += 0.1;
            }
            if (character.Boots?.ItemType == ItemType.DvemerikArmor)
            {
                character.Boots.ClassMultiplier += 0.1;
            }
        }
    }
}
