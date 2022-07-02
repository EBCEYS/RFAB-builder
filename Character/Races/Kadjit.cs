using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Races
{
    internal class Kadjit : IBaseRace
    {
        public string Name { get; set; } = "Каджит";
        public string Description { get; set; } = "30 безоружного урона. 15% скорости передвижения. 15% скорости передвижения во время спринта. 25% приглужения шагов. 95% снижение урона от падения. 50% сопротивления болезням. Переключаемая способность \"Инстинкт\", которая позволяет обнаруживать кого угодно, если вы стоите на месте [имеет ограниченный радиус]. Иммунитет ко всем дебаффам от скумы. Скрытность без перка. Крепкий жедудок.";
        public long BaseHP { get; set; } = 90;
        public long BaseMP { get; set; } = 90;
        public long BaseST { get; set; } = 120;
        public double BaseHPRegen { get; set; } = 0.0;
        public double BaseMPRegen { get; set; } = 1.1;
        public double BaseSTRegen { get; set; } = 1.65;
        public long BaseUnarmedDamage { get; set; } = 45;
        public long BaseWeight { get; set; } = 110;
        public RacesTypes RaceType { get; set; } = RacesTypes.Kadjit;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.WhiteHP += BaseHP;
            character.WhiteMana += BaseMP;
            character.WhiteStamina += BaseST;
            character.HPRegenMultiplyer += BaseHPRegen;
            character.MPRegenMultiplyer += BaseMPRegen;
            character.STRegenMultiplyer += BaseSTRegen;
            character.UnarmedDamage += BaseUnarmedDamage;
            character.Weight += BaseWeight;

            character.MovementSpeed += 0.15;
            character.MovementNoise -= 0.25;
            character.FallDamage += 0.95;
            character.IllResistance += 0.5;

            character.Sneak += 15;
            character.ArtOfTheRogue += 5;
            character.Evasion += 5;
            character.UnarmedFight += 5;
            character.OneHandedWeapon += 5;
            character.Alchemy += 5;
        }
    }
}
