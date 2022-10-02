using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace wrcrft
{
    public abstract class Buildings
    {
        public int FullHealthPoint;
        public int RealHealthPoint;
        public int Coast;

        public Buildings(int HP, int coast)
        {
            FullHealthPoint = HP;
            RealHealthPoint = HP;
            Coast = coast;
        }
        public abstract void UpgradeBuildings();
    }
}
