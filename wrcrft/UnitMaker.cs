using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace wrcrft
{
    public class UnitMaker
    {
        public int DamageLVL = 0;
        public int ArmorLVL = 0;
        public int BowLVL = 0;

        public Unit Make(string name)
        {
            Unit unit = null;

            switch (name)
            {
                case "footMan":
                    unit = new FootMan(DamageLVL, ArmorLVL, BowLVL);
                    break;
                case "archer":
                    unit = new Archer(DamageLVL, ArmorLVL, BowLVL);
                    break;
                case "peasent":
                    unit = new Peasent(DamageLVL, ArmorLVL, BowLVL); ;
                    break;
                default:
                    throw new Exception("Unknown unit");
            }
            return unit;
        }

        public Mage MagicMake(string name)
        {
            Mage mage = new Mage(DamageLVL, ArmorLVL, BowLVL);
            return mage;
        }

        public void UpgradeDamage()
        { 
            if (DamageLVL < 3)
            {
                DamageLVL++;
            }
        }

        public void UpgradeArmor()
        {
            if (ArmorLVL < 3)
            {
                ArmorLVL++;
            }
        }

        public void UpgradeBow()
        {
            if (BowLVL < 3)
            {
                BowLVL++;
            }
        }
    }
}
