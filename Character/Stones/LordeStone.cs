using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Stones
{
    public class LordeStone : IBaseStone
    {
        public string Name { get; set; } = "Лорд";
        public string Description { get; set; } = "10% сопротивления магии. 10% сопротивления стихиям. 15% бонус к рейтингу брони. Увеличивает предел сопротивления стихиям и магии до 75%";

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.ElemResistanceCup += 0.5;
            character.MageResistance += 0.1;
            character.FireResistance += 0.1;
            character.LightningResistance += 0.1;
            character.ColdResistance += 0.1;
            character.ArmourClassMultiplier += 0.15;
        }
    }
}
