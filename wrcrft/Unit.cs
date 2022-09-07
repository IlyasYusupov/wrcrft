using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wrcrft
{
    public abstract class Unit
    {
        public int FullHealthPoint;
        public int RealHealthPoint;
        public int Coast;

        public Dictionary<int, int> LvlDicDamage = new Dictionary<int, int>()
        {
            {0, 0},
            {1, 20},
            {2, 35},
            {3, 50}
        };

        public Dictionary<int, int> LvlDicArmor = new Dictionary<int, int>()
        {
            {0, 0},
            {1, 30},
            {2, 40},
            {3, 60}
        };

        public Dictionary<int, int> LvlDicBow = new Dictionary<int, int>()
        {
            {0, 0},
            {1, 20},
            {2, 40},
            {3, 50}
        };

        public abstract int Damage { get; set; }

        public Unit(int HP, int coast, int damage, int DamageLVL, int ArmorLVL, int BowLVL)
        {
            FullHealthPoint = HP;
            RealHealthPoint = HP;
            Coast = coast;
            Damage = damage;
            Map.Units.Add(this);
        }

        public int Health
        {
            get { return RealHealthPoint; }
            set
            {
                RealHealthPoint = value;

                if (RealHealthPoint < FullHealthPoint * 0.25)
                {
                    DiminutionHealthEvent?.Invoke();
                }
            }
        }

        public void TakeDamage(int damage) => Health -= damage;

        public delegate void DiminutionHealtDelegate();

        public abstract void Attack(Unit unit);

        public event DiminutionHealtDelegate DiminutionHealthEvent;


    }

}
