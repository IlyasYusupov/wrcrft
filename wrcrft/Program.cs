using System;

namespace wrcrft
{
    class Program
    {
        static void Main()
        {
            UnitMaker unitMaker = new UnitMaker();
            Unit footMan = unitMaker.Make("footMan");
            footMan.Name = "Юра";
            Unit targetFootMan = unitMaker.Make("footMan");
            targetFootMan.Name = "Влад";
            //Unit Archer = unitMaker.Make("archer");
            //Mage mage = unitMaker.MagicMake();
            /*BlackSmith smith = new BlackSmith(unitMaker);*/
            
            Console.WriteLine($"Урон {footMan.Name}: {footMan.Damage}");
            Console.WriteLine($"Броня {footMan.Name}: {footMan.Armor}");
            Console.WriteLine($"Урон {targetFootMan.Name}: {targetFootMan.Damage}");
            Console.WriteLine($"Броня {targetFootMan.Name}: {targetFootMan.Armor}");
            Task.Run(() => Fight(targetFootMan, footMan));
            Task.Run(() => Fight(footMan, targetFootMan)).Wait();

            //BlackSmith smith = new BlackSmith(unitMaker);
            //smith.UpgradeDamage();
            //smith.UpgradeArmor();

            //Console.WriteLine($"Урон footMan после улучшения: {footMan.Damage}");
            //Console.WriteLine($"Броня footMan полсе улучшения: {footMan.Armor} \n");


            //Console.WriteLine($"Полное здоровье footMan: {footMan.FullHealthPoint}");
            //Console.WriteLine($"Полное здоровье targetFootMan: {targetFootMan.FullHealthPoint}");
            //Console.WriteLine($"Количество маны у mage: {mage.Mane} \n");
            //while (targetFootMan.RealHealthPoint > 0 && footMan.RealHealthPoint > 0)
            //{
            //    targetFootMan.Attack(footMan);
            //    Console.WriteLine($"Здоровье footMan после атаки: {footMan.RealHealthPoint}");

            //    footMan.Attack(targetFootMan);
            //    Console.WriteLine($"Здоровье targetFootMan после атаки: {targetFootMan.RealHealthPoint}");

            //    mage.targetHeal(footMan);
            //    Console.WriteLine($"Здоровье footMan после лечения: {footMan.RealHealthPoint}");
            //    Console.WriteLine($"Оставшееся количество маны: {mage.Mane} \n");
            //}
            //Console.WriteLine("Итог:");
            //Console.WriteLine($"Оставшеeся здоровье {footMan.Name}: {footMan.RealHealthPoint}");
            //Console.WriteLine($"Оставшеeся здоровье {targetFootMan.Name}: {targetFootMan.RealHealthPoint}");
            //Console.WriteLine($"Оставшеeся количество маны: {mage.Mane}");
        }
        static void Fight(Unit attackUnit, Unit targetUnit)
        {
            while (attackUnit.RealHealthPoint > 0 && targetUnit.RealHealthPoint > 0)
            {
                Thread.Sleep(100);
                attackUnit.Attack(targetUnit);
                Console.WriteLine($"Здоровье {targetUnit.Name} после атаки: {targetUnit.RealHealthPoint}");
            }
            Task.WhenAll();
        }
    }
}
