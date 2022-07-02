using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class DibellaEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Дибелла.";
        public string Description { get; set; } = "2 МП скидка на поддерживаемые заклинания иллюзии. 15 к навыку иллюзии. 10% шанс поглощения вражеского заклинания.";
        public PassiveEffectType Type { get; set; } = PassiveEffectType.GodBlessing;
        public int? PowerLevel { get; set; } = 1;
        public Color Color { get; set; } = Color.Purple;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            if (character.IsGood)
            {
                //TODO:добавить проверку что если есть спелл иллюзии, то у него -2 манакоста.
                character.Illusion += 15;
                character.ChanceToAbsorbSpell += 0.1;
            }
        }
    }
}
