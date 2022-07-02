using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class LordOfClanVolkiharEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Лорд Клана Волкихар";
        public string Description { get; set; } = " 10% снижения урона от любой нежити. 10% снижение стоимости заклинаний школы колдовства.";
        public PassiveEffectType Type { get; set; } = PassiveEffectType.MainStory;
        public int? PowerLevel { get; set; } = 1;
        public Color Color { get; set; } = Color.Blue;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.UndeadResistance += 0.1;
            character.ConjurCost -= 0.1;
        }
    }
}
