﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character
{
    internal interface IBaseRace
    {
        string Name { get; set; }
        void Effect();
        string Description { get; set; }
        void Effect(Character character);
        long BaseHP { get; set; }
        long BaseMP { get; set; }
        long BaseST { get; set; }

        double BaseHPRegen { get; set; }
        double BaseMPRegen { get; set; }
        double BaseSTRegen { get; set; }

        long BaseUnarmedDamage { get; set; }
        long BaseWeight { get; set; }
    }
}
