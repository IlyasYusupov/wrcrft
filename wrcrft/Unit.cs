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

        public abstract int Damage { get; set; }

        public Unit(int HP, int coast, int damage)
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

        //public void Upgrade()
        //{

        //}


        public event DiminutionHealtDelegate DiminutionHealthEvent;
    }

}
