using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wrcrft
{
    public class Peasent : Unit
    {
        public Peasent(int DamageLVL, int ArmorLVL, int BowLVL) : base(35, 5, 4, DamageLVL, -1, -1)
        { }

        public override int Damage { get; set; }

        public override void Attack(Unit targetUnit)
        {
            if (targetUnit.RealHealthPoint > 0 && RealHealthPoint > 0)
            {
                targetUnit.TakeDamage(Damage);

                if (targetUnit.RealHealthPoint < 0)
                {
                    targetUnit.RealHealthPoint = 0;
                }
            }
        }

        public void Mining()
        { }

        public void Building()
        { }
        public void Repair()
        { }
    }
}
