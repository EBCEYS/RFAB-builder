using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character
{
    internal class Character
    {
        #region BaseStats
        public string Name { get; set; }
        public long WhiteHP { get; set; } = 0;
        public long BlueHP { get; set; } = 0;
        public long WhiteMana { get; set; } = 0;
        public long BlueMana { get; set; } = 0;
        public long WhiteStamina { get; set; } = 0;
        public long BlueStamina { get; set; } = 0;
        public long Level { get; set; } = 0;
        public IBaseRace Race { get; set; } = null;
        public double HPRegen { get; set; } = 0.0;
        public double MPRegen { get; set; } = 0.0;
        public double STRegen { get; set; } = 0.0;

        public double Trade { get; set; } = 0.0;
        public double Weight { get; set; } = 0.0;

        /// <summary>
        /// Праведность.
        /// </summary>
        public bool IsGood { get; set; } = true;
        #endregion

        #region OffenceStats
        public double MagePower { get; set; } = 0.0;
        public double PoisonMagePower { get; set; } = 0.0;
        public double PoisonPowerAndDuration { get; set; } = 0.0;
        public long PoisonNumber { get; set; } = 1;

        public double OneHandedDamage { get; set; } = 0.0;
        public double TwoHandedDamage { get; set; } = 0.0;
        public double ArcheryDamage { get; set; } = 0.0;
        public long UnarmedDamage { get; set; } = 0;
        public double BeastsDamage { get; set; } = 0.0;
        public double DragonsDamage { get; set; } = 0.0;
        public double UndeadDamage { get; set; } = 0.0;

        public long OneHandedMastery { get; set; } = 0;
        public long TwoHandedMastery { get; set; } = 0;
        public long ArcheryMastery { get; set; } = 0;

        public double AttackSpeed { get; set; } = 0.0;
        public double MovementSpeed { get; set; } = 1.0;
        public double ShoutsCooldownRecovery { get; set; } = 1.5;

        #endregion

        #region DefStats
        public long ArmourClass { get; set; } = 0;

        public double DefPercent { get; set; } = 0.0;
        public double MageResistance { get; set; } = 0.0;
        public double FireResistance { get; set; } = 0.0;
        public double ColdResistance { get; set; } = 0.0;
        public double LightningResistance { get; set; } = 0.0;
        public double IllResistance { get; set; } = 0.0;
        public double PoisonResistance { get; set; } = 0.0;
        public double ArcheryResistance { get; set; } = 0.0;
        public double BeastResistance { get; set; } = 0.0;
        public double DragonResistance { get; set; } = 0.0;
        public double UndeadResistance { get; set; } = 0.0;
        public double ChanceToAbsorbSpell { get; set; } = 0.0;

        public double Stability { get; set; } = 0.0;
        public double FallDamage { get; set; } = 1.0;

        public bool HPRangTwo { get; set; } = false;
        public bool MPRangTwo { get; set; } = false;
        public bool STRangTwo { get; set; } = false;

        public bool ImmuneToBurnMP { get; set; } = false;
        public bool ImmuneToBurnST { get; set; } = false;

        public double DefPercentCup { get; set; } = 0.7;
        public double MageResistanceCup { get; set; } = 0.7;
        public double ElemResistanceCup { get; set; } = 0.7;
        public double AbsorbCup { get; set; } = 0.7;
        #endregion

        #region Stealth
        public double MovementNoise { get; set; } = 1.0;
        public double SneakMastery { get; set; } = 0.0;
        #endregion

        public List<IBasePerk> Perks { get; set; } = new List<IBasePerk>();
        public List<IBasePassiveEffect> Effects { get; set; } = new List<IBasePassiveEffect>();

        #region Inventory
        public IBaseItem Head { get; set; } = null;
        public IBaseItem BodyArmour { get; set; } = null;
        public IBaseItem Gloves { get; set; } = null;
        public IBaseItem Boots { get; set; } = null;
        public IBaseItem Ring { get; set; } = null;
        public IBaseItem Amulet { get; set; } = null;
        public IBaseItem LeftHand { get; set; } = null;
        public IBaseItem RightHand { get; set; } = null;
        public List<IBaseItem> Inventory { get; set; } = new List<IBaseItem>();
        #endregion

        #region MageCosts
        public double IllusionCost { get; set; } = 1.0;
        public double ConjurCost { get; set; } = 1.0;
        public double DestrCost { get; set; } = 1.0;
        public double RestoreCost { get; set; } = 1.0;
        public double AlterationCost { get; set; } = 1.0;
        #endregion

        public void SetDefaultStats()
        {
            BlueHP = 0;
            BlueMana = 0;
            BlueStamina = 0;
            Level = CalcLevel();

            Trade = 0.0;

            WhiteHP = Race.BaseHP;
            WhiteMana = Race.BaseMP;
            WhiteStamina = Race.BaseST;
            HPRegen = Race.BaseHPRegen;
            MPRegen = Race.BaseMPRegen;
            STRegen = Race.BaseSTRegen;
            Weight = Race.BaseWeight;
            UnarmedDamage = Race.BaseUnarmedDamage;

            MagePower = 0.0;
            PoisonMagePower = 0.0;
            PoisonPowerAndDuration = 0.0;
            PoisonNumber = 1;
            OneHandedDamage = 0.0;
            TwoHandedDamage = 0.0;
            ArcheryDamage = 0.0;
            BeastsDamage = 0.0;
            DragonsDamage = 0.0;
            UndeadDamage = 0.0;

            OneHandedMastery = 0;
            TwoHandedMastery = 0;
            ArcheryMastery = 0;

            AttackSpeed = 0.0;
            MovementSpeed = 1.0;
            ShoutsCooldownRecovery = 1.5;

            ArmourClass = 0;

            DefPercent = 0.0;
            MageResistance = 0.0;
            FireResistance = 0.0;
            ColdResistance = 0.0;
            LightningResistance = 0.0;
            IllResistance = 0.0;
            PoisonResistance = 0.0;
            ArcheryResistance = 0.0;
            BeastResistance = 0.0;
            DragonResistance = 0.0;
            UndeadResistance = 0.0;
            ChanceToAbsorbSpell = 0.0;

            Stability = 0.0;
            FallDamage = 1.0;

            HPRangTwo = false;
            MPRangTwo = false;
            STRangTwo = false;

            ImmuneToBurnMP = false;
            ImmuneToBurnST = false;

            DefPercentCup = 0.7;
            MageResistanceCup = 0.7;
            ElemResistanceCup = 0.7;
            AbsorbCup = 0.7;

            MovementNoise = 1.0;
            SneakMastery = 0.0;

            IllusionCost = 1.0;
            ConjurCost = 1.0;
            DestrCost = 1.0;
            RestoreCost = 1.0;
            AlterationCost = 1.0;
        }

        public long CalcLevel()
        {
            return Perks.Count - 3;
        }

        public Character(IBaseRace race, string name)
        {
            Logger.Info($"Set character with name: {name} with race:");
            Logger.Info(race);
            this.Race = race;
            this.Name = name;
        }

        public void Effect()
        {
            SetDefaultStats();
            Race.Effect(this);
            foreach (IBaseItem item in Inventory)
            {
                item.Effect(this);
            }
            foreach(IBasePerk perk in Perks)
            {
                perk.Effect(this);
            }
            foreach(IBasePassiveEffect effect in Effects)
            {
                effect.Effect(this);
            }
        }
    }
}
