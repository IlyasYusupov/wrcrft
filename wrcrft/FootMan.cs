using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wrcrft
{
    public class FootMan : Unit
    {
        public FootMan(int DamageLVL, int ArmorLVL, int BowLVL) : base(60, 15, 11, DamageLVL, ArmorLVL, -1)
        {
            Armor = 7;
            this.DiminutionHealthEvent += Rage; 
            
            Damage += Damage * DictionaryLvlDamage[DamageLVL] / 100;
            Armor += Armor * DictionaryLvlArmor[DamageLVL] / 100;
        }
        
        public override int Damage {get; set;}

        public int DamageReduction(int damage)
        {
            damage =  (int)(damage - (Armor * 0.7));
            return damage;
        }

        public override void Attack(Unit targetUnit)
        {
            if (targetUnit.RealHealthPoint > 0 && RealHealthPoint > 0) 
            {

                targetUnit.TakeDamage(DamageReduction(Damage));

                if (targetUnit.RealHealthPoint < 0)
                {
                    targetUnit.RealHealthPoint = 0;
                }
            }
        }

        public void Rage() => Damage += (int)(Damage * 0.25);
    }
}
