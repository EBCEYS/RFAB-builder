using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character
{
    public interface IBaseItem
    {
        string Name { get; set; }
        void Effect();
        ItemSlot Slot { get; set; }
        string Description { get; set; }
        ItemType ItemType { get; set; }
        void Effect(Characters character);
        List<IBaseEnchant> Enchants { get; set; }
        /// <summary>
        /// Base = 1.0;
        /// </summary>
        double ClassMultiplier { get; set; }
    }

    public enum ItemType
    {
        dvemerik
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
