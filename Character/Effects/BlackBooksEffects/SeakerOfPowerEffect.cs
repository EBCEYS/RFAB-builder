using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class SeakerOfPowerEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Искатель силы";
        public string Description { get; set; } = "10% урона оружием";
        public PassiveEffectType Type { get; set; } = PassiveEffectType.BlackBooks;
        public int? PowerLevel { get; set; } = 1;
        public Color Color { get; set; } = Color.Gray;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.WeaponDamageMultiplier += 0.1;
        }
    }
}
