using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class ThiefMasterEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Мастер Вор";
        public string Description { get; set; } = "30 СТ [ранг I]. 10% бонус к торговле. 20 скорости передвижения вне боя. 50 переносимого веса";
        public PassiveEffectType Type { get; set; } = PassiveEffectType.Guilds;
        public int? PowerLevel { get; set; } = 1;
        public Color Color { get; set; } = Color.Red;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.BlueStamina += 30;
            character.Trade += 0.1;
            character.MovementSpeed += 0.2;
            character.Weight += 50;
        }
    }
}
