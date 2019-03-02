using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region urok2
            /// <summary>
            ///  создать часть скрипта что бы при по вышении уровня  до 100 повышались параметры 
            /// </summary>

            int HPcastl = 1000; // хп здания
            int protection = 1; // защита здания
            int lvl; // уровень здания

            int costUp = 10; // цена улутшения

            int money = 10000; //заменить из глобал базы 
            int[] lvlUp = new int[100];
            Console.Write("Ввидите lvl: ");
            lvl = Convert.ToInt32(Console.ReadLine());
            
            if(lvl > 100 )
            {
                lvl = 100;
                Console.WriteLine("Уровень привышен и стал 100");
            }
            lvlUp[lvl] = lvl;
            if (money >= costUp && lvl < 100)
            {

                lvl++;
                HPcastl *= lvl;
                protection += 3 * lvl;
                costUp += 200 * lvl;
                money -= costUp;
                Console.WriteLine($"лвл : {lvl} Зашита: {protection} Деньги осталось: {money} Хп здания {HPcastl}");
            }

            Console.ReadKey();

            #endregion urok2


        }
        

    }   
}
