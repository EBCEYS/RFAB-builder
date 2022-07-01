using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Stones
{
    public class AtronahStone : IBaseStone
    {
        public string Name { get; set; } = "Атронах";
        public string Description { get; set; } = "300 МП [ранг 1]. 50% поглощения заклинаний. Увеличение предела поглощения заклинаний до 90%. Еда не работает. Зелья магии работают в 2 раза хуже. Процентная регенирация Магии не работает.";

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.WhiteMana += 300;
            character.ChanceToAbsorbSpell += 0.5;
            character.AbsorbCup = 0.9;
            character.MPRegenPercents = 0.0;
        }
    }
}
