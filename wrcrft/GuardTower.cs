using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wrcrft
{
    public class GuardTower : Buildings
    {
        public int Damage;
        public int Range;

        public GuardTower() : base(100,20)
        { }

        public override void UpgradeBuildings()
        { }
    }
}
