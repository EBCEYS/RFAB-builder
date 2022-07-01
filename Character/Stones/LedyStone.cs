using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Stones
{
    public class LedyStone : IBaseStone
    {
        public string Name { get; set; } = "Леди";
        public string Description { get; set; } = "15% скорости атаки любым оружием. 2/3/4/5 СТ регена на 1-4/5-9/10-14-15+ уровне. Вражеские заклинания холода больше не сжигают СТ.";

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.AttackSpeed += 0.15;
            if (character.Level >= 1 && character.Level <= 4)
            {
                character.STRegenDigit += 2;
            }
            else if (character.Level >= 5 && character.Level <= 9)
            {
                character.STRegenDigit += 3;
            }
            else if (character.Level >= 10 && character.Level <= 14)
            {
                character.STRegenDigit += 4;
            }
            else
            {
                character.STRegenDigit += 5;
            }
        }
    }
}
