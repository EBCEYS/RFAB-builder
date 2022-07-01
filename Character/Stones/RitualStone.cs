using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Stones
{
    public class RitualStone : IBaseStone
    {
        public string Name { get; set; } = "Ритуал";
        public string Description { get; set; } = "20% снижение стоимости заклинаний колдовства. Увеличивает количество призываемых и поднятых существ на 1. Позволяет абсолютно бесплатно произносить и поддерживать любую некроауру.";

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.ConjurCost -= 0.2;
            character.SummonedUnitsNumber += 1;
        }
    }
}
