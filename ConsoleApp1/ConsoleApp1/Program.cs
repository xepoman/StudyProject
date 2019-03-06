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
                /* // сортировки (написать пузырьком сортировку)  самому
                 ЦИКЛ ДЛЯ J = 1 ДО N-1 ШАГ 1                       FOR J = 1 TO N-1 STEP 1
                  F = 0                                             F = 0
                  ЦИКЛ ДЛЯ I = 1 ДО N-J ШАГ 1                       FOR I = 1 TO N-J STEP 1
                  ЕСЛИ A[I] > A[I + 1] ТО ОБМЕН A[I],A[I + 1]:F = 1     IF A[I]> A[I + 1] THEN SWAP A[I],A[I + 1]:F = 1
                 СЛЕДУЮЩЕЕ I                                     NEXT I
                  ЕСЛИ F = 0 ТО ВЫХОД ИЗ ЦИКЛА                      IF F = 0 THEN EXIT FOR
                  СЛЕДУЮЩЕЕ J NEXT J
                  */
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
                  //  Console.WriteLine($"{mass[i]}");

                }
                Console.WriteLine(mass[t]);
            }


            Console.ReadLine();
        }



       


    }   
}
