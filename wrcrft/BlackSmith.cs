using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wrcrft
{
    public class BlackSmith
    {
        public UnitMaker unitMaker;
        public BlackSmith(UnitMaker unit)
        {
            unitMaker = unit;
        }

        public void UpgradeDamage()
        {
            unitMaker.UpgradeDamage();
        }

        public void UpgradeArmor()
        {
            unitMaker.UpgradeArmor();
        }

        public void UpgradeBow()
        {
            unitMaker.UpgradeBow();
        }

    }
}
