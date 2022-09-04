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
        public int LVL;
        public abstract int Damage { get; set; }

        public Unit(int HP, int coast, int damage)
        {
            FullHealthPoint = HP;
            RealHealthPoint = HP;
            Coast = coast;
            Damage = damage;
        }

        public abstract void Attack(Unit unit);
    }

}
