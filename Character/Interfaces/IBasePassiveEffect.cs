using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character
{
    public interface IBasePassiveEffect
    {
        string Name { get; set; }
        string Description { get; set; }
        PassiveEffectType Type { get; set; }
        int? PowerLevel { get; set; }
        void Effect();
        void Effect(Characters character);
        Color Color { get; set; }
    }

    public enum PassiveEffectType
    {
        GodBlessing,
        MainStory,
        Guilds,
        CivilWar,
        BlessingOfNature,
        BlackBooks,
        AllMakerStone,
        Another
    }
}
