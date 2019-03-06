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
                int[] mass =  new int[7];
            Console.WriteLine("Введите семь чисел");
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write("{0}-е число: ", i + 1);
                mass[i] = Int32.Parse(Console.ReadLine());
            }
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
                  

                }
              

            }
            Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(mass[i]);
            }
            
            Console.ReadLine();
        }



       


    }   
}
