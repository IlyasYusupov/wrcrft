using System;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

namespace wrcrft
{
    class Program
    {
        
        static void Main()
        {
           //Первый Бой
            UnitMaker unitMaker = new UnitMaker();
            Unit firstFootMan = unitMaker.Make("footMan");
            firstFootMan.Name = "ПервыйПерсонажПервогоБоя";
            Unit firstTargetFootMan = unitMaker.Make("footMan");
            firstTargetFootMan.Name = "ВторойПерсонажПервогоБоя";
            Task[] tasks = new Task[4];
            Console.WriteLine($"Урон {firstFootMan.Name}: {firstFootMan.Damage}");
            Console.WriteLine($"Здоровье {firstFootMan.Name}: {firstFootMan.Health}");
            Console.WriteLine($"Урон {firstTargetFootMan.Name}: {firstTargetFootMan.Damage}");
            Console.WriteLine($"Здоровье {firstTargetFootMan.Name}: {firstTargetFootMan.Health}");
            Console.WriteLine();

            //Второй бой
            Unit secondFootMan = unitMaker.Make("footMan");
            secondFootMan.Name = "ПервыйПерсонажВторогоБоя";
            Unit secondTargetFootMan = unitMaker.Make("footMan");
            secondTargetFootMan.Name = "ВторойПерсонажВторогоБоя";
            Console.WriteLine($"Урон {secondFootMan.Name}: {secondFootMan.Damage}");
            Console.WriteLine($"Здоровье {secondFootMan.Name}: {secondFootMan.Health}");
            Console.WriteLine($"Урон {secondTargetFootMan.Name}: {secondTargetFootMan.Damage}");
            Console.WriteLine($"Здоровье {secondTargetFootMan.Name}: {secondTargetFootMan.Health}");
            Console.WriteLine();
            tasks[0] = Task.Run(() => Fight(firstTargetFootMan, firstFootMan, 1));
            Thread.Sleep(200);
            tasks[1] = Task.Run(() => Fight(firstFootMan, firstTargetFootMan, 1));
            Thread.Sleep(200);
            tasks[2] = Task.Run(() => Fight(secondTargetFootMan, secondFootMan, 2));
            Thread.Sleep(200);
            tasks[3] = Task.Run(() => Fight(secondFootMan, secondTargetFootMan, 2));
            Thread.Sleep(200);
            Task.WaitAll(tasks);




        }
        static void Fight(Unit attackUnit, Unit targetUnit, int l)
        {
            
            while (attackUnit.RealHealthPoint > 0 && targetUnit.RealHealthPoint > 0)
            {
                if(l == 1)
                {
                    Console.WriteLine("--------Первый--Бой-----------");
                    attackUnit.Attack(targetUnit);
                    Console.WriteLine($"Здоровье {targetUnit.Name} после атаки: {targetUnit.RealHealthPoint}");
                    Console.WriteLine("------------------------------");
                    
                }
                else if(l == 2)
                {
                    Console.WriteLine("--------Второй--Бой-----------");
                    attackUnit.Attack(targetUnit);
                    Console.WriteLine($"Здоровье {targetUnit.Name} после атаки: {targetUnit.RealHealthPoint}");
                    Console.WriteLine("------------------------------");
                    
                }
                Thread.Sleep(500);
            }
            
        }
    }
}
