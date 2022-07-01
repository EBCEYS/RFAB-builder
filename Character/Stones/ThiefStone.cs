using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Stones
{
    public class ThiefStone : IBaseStone
    {
        public string Name { get; set; } = "Вор";
        public string Description { get; set; } = "10% урона одноручным и стрелковым оружием. 20 мастерства одноручному и стрелковому орежию. Позволяет совершать карманные кражи у всех на глазах. Дарует возможность продавать краденое. Дарует перк \"Ловкие пальчики\". Замки уровня новичек и ученик взламываются без перков. Замки уровня адепт и эксперт с перком \"Дешевые трюки\". Замки уровня мастер с перком \"Знание замков\"";

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.OneHandedDamageMultiplier += 0.1;
            character.ArcheryDamageMultiplier += 0.1;

            character.OneHandedMastery += 20;
            character.ArcheryMastery += 20;
        }
    }
}
