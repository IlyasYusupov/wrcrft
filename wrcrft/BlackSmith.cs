using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wrcrft
{
    public class BlackSmith : Buildings
    {
        public UnitMaker unitMaker;
        public BlackSmith(UnitMaker unit) : base(70, 40)
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

        public override void UpgradeBuildings()
        {
            
        }
    }
}
