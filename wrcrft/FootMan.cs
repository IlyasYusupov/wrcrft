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
        public FootMan() : base(60, 15, 11)
        { this.DiminutionHealthEvent += Rage; }
        
        public override int Damage {get; set;}

        public override void Attack(Unit targetUnit)
        {
            if (targetUnit.RealHealthPoint > 0 && RealHealthPoint > 0) 
            {

                

                if (targetUnit.RealHealthPoint < 0)
                {
                    targetUnit.RealHealthPoint = 0;
                }
            }
        }

        public void Rage() => Damage += (int)(Damage * 0.25);
    }
}
