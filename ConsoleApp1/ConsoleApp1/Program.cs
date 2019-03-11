using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static public int faindMin(int[] minmass)
        {
            int min = int.MaxValue;
            for (int i = 0; i < minmass.Length; i++)
            {
                if (minmass[i] < min)
                {
                    min = minmass[i];
                }
            }
            return min;
        }

        static public int[] faindMax(int[] mass)
        {

            int max = 0;
            int index = 0;
            for (int i =0; i<mass.Length; i++)
            {
                
                if(mass[i] > max)
                {
                    max = mass[i];
                    index = i;
                }
                

            }
            mass[index] = max * 10;

            return mass;
        }

        static void Main(string[] args)
        {
            int[] a = { 1, -8, 0, 4 };

        //    int[] b = faindMax(a);
           

            Console.WriteLine(faindMin(a)+"\n");


            for (int i = 0; i < faindMax(a).Length; i++)
            {
                Console.WriteLine(faindMax(a)[i]);
            }
           

            Console.ReadLine();
        }

       
        //перегрузка функциий 
        // прочитать ОП

    }   
}
