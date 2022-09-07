using System;

namespace wrcrft
{
    class Program
    {
        static void Main()
        {
            UnitMaker unitMaker = new UnitMaker();
            Unit footMan = unitMaker.Make("footMan");
            Unit targetFootMan = unitMaker.Make("footMan");
            Unit Archer = unitMaker.Make("archer");
            Mage mage = unitMaker.MagicMake();

            BlackSmith smith = new BlackSmith(unitMaker);
            smith.UpgradeDamage();
            smith.UpgradeArmor();


            Console.WriteLine($"Полное здоровье footMan: {footMan.FullHealthPoint}");
            Console.WriteLine($"Полное здоровье targetFootMan: {targetFootMan.FullHealthPoint}");
            Console.WriteLine($"Количество маны у mage: {mage.Mane} \n");
            while (targetFootMan.RealHealthPoint > 0 && footMan.RealHealthPoint > 0)
            {
                targetFootMan.Attack(footMan);
                Console.WriteLine($"Здоровье footMan после атаки: {footMan.RealHealthPoint}");

                footMan.Attack(targetFootMan);
                Console.WriteLine($"Здоровье targetFootMan после атаки: {targetFootMan.RealHealthPoint}");

                mage.targetHeal(footMan);
                Console.WriteLine($"Здоровье footMan после лечения: {footMan.RealHealthPoint}");
                Console.WriteLine($"Оставшеейся количество маны: {mage.Mane}");

                Console.WriteLine();


            }
            Console.WriteLine("Итог:");
            Console.WriteLine($"Оставшеейся здоровье footMan: {footMan.RealHealthPoint}");
            Console.WriteLine($"Оставшеейся здоровье targetFootMan: {targetFootMan.RealHealthPoint}");
            Console.WriteLine($"Оставшеейся количество маны: {mage.Mane}");
        }
    }
}
