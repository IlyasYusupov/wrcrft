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
        public int DamageLVL;
        public int ArmorLVL;
        public int BowLVL;

        public Unit Make(string name)
        {
            Unit unit = null;

            switch (name)
            {
                case "footMan":
                    unit = new FootMan();
                    break;
                case "archer":
                    unit = new Archer();
                    break;
                case "peasent":
                    unit = new Peasent(); ;
                    break;
                default:
                    throw new Exception("Unknown unit");
            }
            return unit;
        }
        public Mage MagicMake(string name)
        {
            Mage mage = new Mage();
            return mage;
        }

    }
}
