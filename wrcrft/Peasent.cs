using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wrcrft
{
    public class Peasent : Unit
    {
        public int Mining;
        //public ? Building;
        //public ? Repair;

        public Peasent() : base(35, 5, 4)
        { }

        public override int Damage { get; set; }

        public override void Attack(Unit targetUnit)
        {
            if (targetUnit.RealHealthPoint > 0 && RealHealthPoint > 0)
            {
                targetUnit.RealHealthPoint -= Damage;

                if (targetUnit.RealHealthPoint < 0)
                {
                    targetUnit.RealHealthPoint = 0;
                }
            }
        }
    }
}
