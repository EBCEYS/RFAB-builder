using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Races
{
    internal class Nord : IBaseRace
    {
        public string Name { get; set; } = "Норд";
        public string Description { get; set; } = "35% сопротивления холоду. 15% сопротивления молниям. 15% снижение длительности перезарядки криков. 25% снижения стоимости силовых атак.";
        public long BaseHP { get; set; } = 120;
        public long BaseMP { get; set; } = 80;
        public long BaseST { get; set; } = 120;
        public double BaseHPRegen { get; set; } = 0.0;
        public double BaseMPRegen { get; set; } = 0.01;
        public double BaseSTRegen { get; set; } = 0.0165;
        public long BaseUnarmedDamage { get; set; } = 9;
        public long BaseWeight { get; set; } = 140;
        public RacesTypes RaceType { get; set; } = RacesTypes.Nord;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.WhiteHP += BaseHP;
            character.WhiteMana += BaseMP;
            character.WhiteStamina += BaseST;
            character.HPRegenPercents += BaseHPRegen;
            character.MPRegenPercents += BaseMPRegen;
            character.STRegenPercents += BaseSTRegen;
            character.UnarmedDamage += BaseUnarmedDamage;
            character.Weight += BaseWeight;

            character.ColdResistance += 0.35;
            character.LightningResistance += 0.15;
            character.ShoutsCooldownRecovery += 0.15;
            character.ReduceCostOfPowerAttacks -= 0.25;

            character.Speech += 10;
            character.TwoHandedWeapon += 10;
            character.OneHandedWeapon += 5;
            character.Block += 5;
            character.Smithing += 5;
            character.Smithing += 5;
        }
    }
}
