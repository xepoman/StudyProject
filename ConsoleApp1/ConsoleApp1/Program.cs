using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

       

            

        static public void Main(string[] args)
        {
               
                  // сравниваем два числа если первое больше второго то меняем их местами
                int[] mass =  { 5, 4, 3, 2, 1 };
            int c = 0;
            int f = 0;
            for (int t = 0; t < mass.Length; t++)
            {
                for (int i = 0; i < mass.Length; i++)
                {
                    f = i + 1;
                    if (f == mass.Length)
                    {
                        f = i;

                    }
                    if (mass[i] > mass[f])
                    {
                        c = c + mass[i];
                        mass[i] = mass[i + 1];
                        mass[i + 1] = c;
                        c = 0;
                    }
                    Console.WriteLine($"после цикла i: {mass[i]}");

                }
                Console.WriteLine($" полсе  цикла t: {mass[t]}");
            }
          
            Console.WriteLine($"спомошью всех ячеек {mass[0]} {mass[1]} {mass[2]} {mass[3]} {mass[4]}");
            Console.ReadLine();
        }



       


    }   
}
