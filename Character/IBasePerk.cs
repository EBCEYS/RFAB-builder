using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character
{
    internal interface IBasePerk
    {
        string Name { get; set; }
        string Description { get; set; }
        void Effect();
        void SetPerksClasses(PerkClass perkClass);
        BasePerkClass BasePerkClass { get; set; }
        PerkClass PerkClass { get; set; }
        void Effect(Character character);
    }

    public static class PerkConverter
    {
        public static string ToRusString(PerkClass perkClass)
        {
            switch(perkClass)
            {
                case PerkClass.Smithing: return "Кузнечное дело";
                case PerkClass.HeavyArmour: return "Тяжелая броня";
                case PerkClass.Block: return "Блокирование";
                case PerkClass.TwoHandedWeapon: return "Двуручное оружие";
                case PerkClass.OneHandedWeapon: return "Одноручное оружие";
                case PerkClass.Archery: return "Стрельба";
                case PerkClass.Evasion: return "Уклонение";
                case PerkClass.Sneak: return "Скрытность";
                case PerkClass.Speech: return "Сила голоса";
                case PerkClass.UnarmedFight: return "Рукопашный бой";
                case PerkClass.ArtOfTheRogue: return "Искусство мошенника";
                case PerkClass.Alchemy: return "Алхимия";
                case PerkClass.Illusion: return "Иллюзия";
                case PerkClass.Conjuration: return "Колдовство";
                case PerkClass.Destruction: return "Разрушение";
                case PerkClass.Restoration: return "Восстановление";
                case PerkClass.Alteration: return "Изменеие";
                case PerkClass.Enchanting: return "Зачарование";
                default: return "Неизвестная ветка";
            }
        }
        public static BasePerkClass GetBasePerkClass(PerkClass perkClass)
        {
            switch (perkClass)
            {
                case PerkClass.Smithing: return BasePerkClass.Warrior;
                case PerkClass.HeavyArmour: return BasePerkClass.Warrior;
                case PerkClass.Block: return BasePerkClass.Warrior;
                case PerkClass.TwoHandedWeapon: return BasePerkClass.Warrior;
                case PerkClass.OneHandedWeapon: return BasePerkClass.Warrior;
                case PerkClass.Archery: return BasePerkClass.Warrior;
                case PerkClass.Evasion: return BasePerkClass.Rogue;
                case PerkClass.Sneak: return BasePerkClass.Rogue;
                case PerkClass.Speech: return BasePerkClass.Rogue;
                case PerkClass.UnarmedFight: return BasePerkClass.Rogue;
                case PerkClass.ArtOfTheRogue: return BasePerkClass.Rogue;
                case PerkClass.Alchemy: return BasePerkClass.Rogue;
                case PerkClass.Illusion: return BasePerkClass.Mage;
                case PerkClass.Conjuration: return BasePerkClass.Mage;
                case PerkClass.Destruction: return BasePerkClass.Mage;
                case PerkClass.Restoration: return BasePerkClass.Mage;
                case PerkClass.Alteration: return BasePerkClass.Mage;
                case PerkClass.Enchanting: return BasePerkClass.Mage;
                default: return BasePerkClass.Warrior;
            }
        }
    }

    public enum PerkClass
    {
        #region WarriorPerks
        Smithing,
        HeavyArmour,
        Block,
        TwoHandedWeapon,
        OneHandedWeapon,
        Archery,
        #endregion
        #region Rogue
        Evasion,
        Sneak,
        Speech,
        UnarmedFight,
        ArtOfTheRogue,
        Alchemy,
        #endregion
        #region Mage
        Illusion,
        Conjuration,
        Destruction,
        Restoration,
        Alteration,
        Enchanting
        #endregion
    }

    public enum BasePerkClass
    {
        Warrior,
        Mage,
        Rogue
    }
}
