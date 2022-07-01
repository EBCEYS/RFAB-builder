using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Stones
{
    public class HorseStone : IBaseStone
    {
        public string Name { get; set; } = "Конь";
        public string Description { get; set; } = "50 СТ [ранг 2]. 15% скорости передвижения. 100 переносимого веса. 0.35 снижения влияния надетой брони.";

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.BlueStamina += 50;
            character.STRangTwo = true;
            character.MovementSpeed += 0.15;
            character.Weight += 100;
        }
    }
}
