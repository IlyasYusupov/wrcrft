﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wrcrft
{
    public class Archer : Unit
    {
        public int Armor;
        public int ArrowCount;

        public Archer() : base(45, 10, 9)
        {
            ArrowCount = 20;
        }

        public override int Damage { get; set; }

        public override void Attack(Unit targetUnit)
        {
            if (targetUnit.RealHealthPoint > 0 && RealHealthPoint > 0)
            {
                if (ArrowCount > 0)
                {
                    targetUnit.RealHealthPoint -= Damage;
                    ArrowCount -= 1;
                }

                if (targetUnit.RealHealthPoint < 0)
                {
                    targetUnit.RealHealthPoint = 0;
                }
            }
        }
    }
}