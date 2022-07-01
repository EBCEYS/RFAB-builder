using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Stones
{
    public class ShadowStone : IBaseStone
    {
        public string Name { get; set; } = "Тень";
        public string Description { get; set; } = "25% бесшумности. 50% скорости передвижения в режиме скрытность. Активная способность, позволяющая становиться невидимым на 10 секунд. Перезарядка 15 секунд.";

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.MovementNoise -= 0.25;
        }
    }
}
