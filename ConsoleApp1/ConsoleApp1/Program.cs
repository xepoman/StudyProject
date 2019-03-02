using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
  Команда Big-dipper — это Денис, Адиль и Надира. Но это никак не помогает решить задачу.

Входные данные
Два целых числа A и B (оба от 1 до 1000).

Выходные данные
Одно целое число.

    входное 
    7 2
    выход 
    95

    вход
     2 2
     выход
     40

    вход 
    235 152
    выход
    38783

    вход 
    15 25
    выход
    0

  
  */
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 235;
            int b = 152;
            int c = 0;

            if ((a - b) >= 0)
            {

                Console.WriteLine((a + b) + "" + (a - b));
            }
            else
            {
                Console.WriteLine(c);
            }
            Console.ReadLine();

        }


        
    }
}
