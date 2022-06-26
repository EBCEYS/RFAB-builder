using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character
{
    internal interface IBaseItem
    {
        string Name { get; set; }
        void Effect();
        ItemSlot Slot { get; set; }
        string Description { get; set; }
        void Effect(Character character);
    }

    public enum ItemSlot
    {
        Head,
        BodyArmour,
        Gloves,
        Boots,
        Ring,
        Amulet,
        LeftHand,
        RightHand
    }
}
