using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Stones
{
    public class LoverStone : IBaseStone
    {
        public string Name { get; set; } = "Любовник";
        public string Description { get; set; } = "30 сила голоса. 20% снижение длительности перезарядки критиков. 30% снижение входящего урона от криков. Увеличивает предел снижения перезарядки криков с 15% до 10%. Позволяет не наносить урон союзникам во время боя. Дополнительно расширяет ассортимент торговцев.";

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.Speech += 30;
            character.ShoutsDamageReduction += 0.3;
        }
    }
}
