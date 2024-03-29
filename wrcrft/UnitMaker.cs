﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace wrcrft
{
    public class UnitMaker
    {
        public int DamageLVL = 0;
        public int ArmorLVL = 0;
        public int BowLVL = 0;
        public static List<Unit> Units = new List<Unit>();

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
                    unit = new Peasent(DamageLVL, ArmorLVL, BowLVL);
                    break;
                default:
                    throw new Exception("Unknown unit");
            }
            Units.Add(unit);
            return unit;
        }

        public Mage MagicMake()
        {
            Mage mage = new Mage(DamageLVL, ArmorLVL, BowLVL);
            Units.Add(mage);
            return mage;
        }

        public void CheckingUpdate()
        {
            foreach(var i in Units)
            {            
                if (i.DamageLVL != DamageLVL && i.DamageLVL != -1)
                {
                    i.Damage += i.Damage * i.DictionaryLvlDamage[DamageLVL] / 100;
                    i.DamageLVL++;
                }
                if (i.ArmorLVL != ArmorLVL && i.ArmorLVL != -1)
                {
                    i.Armor += i.Armor * i.DictionaryLvlArmor[ArmorLVL] / 100;
                    i.ArmorLVL++;
                }
                if (i.BowLVL != BowLVL && i.BowLVL != -1)
                {
                    i.Damage += i.Damage * i.DictionaryLvlBow[BowLVL] / 100;
                    i.BowLVL++;
                    i.ArrowCount += 2;
                    
                }
            }
        }

        public void UpgradeDamage()
        {
            if (DamageLVL < 3)
            {
                DamageLVL++;
            }
            CheckingUpdate();
        }

        public void UpgradeArmor()
        {
            if (ArmorLVL < 3)
            {
                ArmorLVL++;
            }
            CheckingUpdate();
        }

        public void UpgradeBow()
        {
            if (BowLVL < 3)
            {
                BowLVL++;
            }
            CheckingUpdate();
        }
    }
}
