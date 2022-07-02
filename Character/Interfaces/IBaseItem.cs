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
        /// <summary>
        /// Значение предмета. В случае брони - класс брони. В случае оружия - базовый урон.
        /// </summary>
        long ItemValue { get; set; }
    }

    public enum ItemType
    {
        #region LightArmor
        /// <summary>
        /// Сыроматная броня.
        /// </summary>
        RawhideArmor,
        /// <summary>
        /// Меховая броня.
        /// </summary>
        FurArmor,
        /// <summary>
        /// Клепанная броня.
        /// </summary>
        StuddedArmor,
        /// <summary>
        /// Кожанная броня.
        /// </summary>
        LetherArmor,
        ElfikArmor,
        GoldenElfikArmor,
        LamellarArmor,
        HitinArmorLight,
        GlassArmor,
        StalgrimArmorLight,
        DragonScalesArmor,
        #endregion

        #region HeavyArmor
        IronArmor,
        StrongIronArmor,
        SteelArmor,
        SteelPlasticArmor,
        HitinArmorHeavy,
        BoneArmor,
        StrongBoneArmor,
        NordsArmor,
        OrksArmor,
        DvemerikArmor,
        EbonitArmor,
        StalgrimArmorHeavy,
        DragonArmorHeavy,
        DaedricArmor,
        #endregion

        #region Weapon
        IronWeapon,
        SteelWeapon,
        OrksWeapon,
        DvemerikWeapon,
        ElfWeapon,
        NordicWeapon,
        GlassWeapon,
        EbonitWeapon,
        StalgrimWeapon,
        DaedricWeapon,
        DragonWeapon,
        #endregion

        OtherAddIfUWant
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
