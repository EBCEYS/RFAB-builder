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
        void Active();
        ItemSlot Slot { get; set; }
        string Description { get; set; }
        void Active(Character character);
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
