using System;
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

        public Archer(int DamageLVL, int ArmorLVL, int BowLVL) : base(45, 10, 9, DamageLVL, ArmorLVL, BowLVL)
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
                    targetUnit.TakeDamage(Damage);
                    ArrowCount -= 1;
                }

                if (targetUnit.RealHealthPoint < 0)
                {
                    targetUnit.RealHealthPoint = 0;
                }
            }
        }
        public void UpgradeBow()
        {
            if (BowLVL < 3)
            {
                ArrowCount += 2;
                Damage -= 2;
            }
        }
    }
}
