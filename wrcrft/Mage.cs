using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wrcrft
{
    public class Mage : Unit
    {
        public int Mane;
        public int HealSkill;
        
        public Mage() : base(45, 18, 15)
        {
            HealSkill = 7;
            Mane = 45;
            this.DiminutionHealthEvent += selfHeal;
        }

        public override int Damage { get; set; }

        public void castFireBall()
        { }

        public void targetHeal(Unit unit)
        {
            if (unit.RealHealthPoint > 0 && unit.RealHealthPoint < FullHealthPoint && Mane >= 15)
            {
                Mane -= 15;
                unit.RealHealthPoint += HealSkill;

                if (unit.RealHealthPoint > FullHealthPoint)
                {
                    unit.RealHealthPoint = FullHealthPoint;
                }
            }
        }

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

        public void selfHeal() => targetHeal(this);
    }
}