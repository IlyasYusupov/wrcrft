using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wrcrft
{
    public class FootMan : Unit
    {
        public int Armor;
        public double Rage;

        public FootMan() : base(60, 15, 11)
        {
            Rage = 0.25;
        }

        public override int Damage {get; set;}

        public override void Attack(Unit targetUnit)
        {
            if (targetUnit.RealHealthPoint > 0 && RealHealthPoint > 0) 
            {
                if (RealHealthPoint <= FullHealthPoint * 0.25) //Включение Rage 
                {
                    Damage += (int)(Damage * Rage);
                }

                targetUnit.RealHealthPoint -= Damage;

                if (targetUnit.RealHealthPoint < 0)
                {
                    targetUnit.RealHealthPoint = 0;
                }
            }
        }
    }
}
