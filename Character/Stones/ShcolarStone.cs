using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Stones
{
    public class ShcolarStone : IBaseStone
    {
        public string Name { get; set; } = "Ученик";
        public string Description { get; set; } = "5/6/7/8 МП регена на 1-4/5-9/10-14/15+ уровне. 10% снижение стоимости всех заклинаний.";

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            if (character.Level >= 1 && character.Level <= 4)
            {
                character.MPRegenDigit += 5;
            }
            else if (character.Level >= 5 && character.Level <= 9)
            {
                character.MPRegenDigit += 6;
            }
            else if (character.Level >= 10 && character.Level <= 14)
            {
                character.MPRegenDigit += 7;
            }
            else
            {
                character.MPRegenDigit += 8;
            }
            character.AlterationCost -= 0.1;
            character.ConjurCost -= 0.1;
            character.DestrCost -= 0.1;
            character.RestoreCost -= 0.1;
            character.IllusionCost -= 0.1;
        }
    }
}
