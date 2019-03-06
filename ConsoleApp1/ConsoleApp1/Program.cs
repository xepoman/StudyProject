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
            /*
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

        if(lvl > 100)
        {
            lvl = 100;
            Console.WriteLine($"Уровень привышен и стал 100");
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

        Console.ReadKey();*/
        
            #endregion urok2
            #region urok3
            char[] chars = { 'w', 'o', 'r', 'd' };
            sbyte[] bytes = { 0x41, 0x42, 0x43, 0x44, 0x45, 0x00 };

            // Создайте строку из массива символов..
            string string1 = new string(chars);
            Console.WriteLine(string1);  // word

            // Создать строку, состоящую из символа, повторенного 20 раз.
            string string2 = new string('c', 20);
            Console.WriteLine(string2); // cccccccccccccccccc

            string string3 = "Дата " + DateTime.Now; //.ToString("D") + "."; // Дата 16.03.2019. 16:00  если используем .ToString("D") + "." то формат будет Дата 16  марат 2019г..
            Console.WriteLine(string3);

            string string4 = "Это одно предложение." + " Это секунда. ";
            string4 += "Это третье предложение.";
            Console.WriteLine(string4); // Это одно предложение. Это секунда. Это третье предложение.

            string sentence = "Это предложение состоит из пяти слов.";
            // Извлечь второе слово.
            int startPosition = sentence.IndexOf(" ") + 1;
            string word2 = sentence.Substring(startPosition,sentence.IndexOf(" ", startPosition) - startPosition);

            Console.WriteLine("Второе слово: " + word2 + "."); //Второе слово: предложение.

            string source = "    Я шире, чем мне нужно быть.      ";
            //Сохраните результаты в новой строковой переменной.
            var trimmedResult = source.Trim();
            var trimLeading = source.TrimStart();
            var trimTrailing = source.TrimEnd();
            Console.WriteLine($"<{source}>");
            Console.WriteLine($"<{trimmedResult}>"); // удаляет пробелы до и после текста
            Console.WriteLine($"<{trimLeading}>");// удаляет пробелы до текста
            Console.WriteLine($"<{trimTrailing}>");// удаляет пробелы после текста
           

            #endregion urok3
            #region urok4
            // var arrS = str.Split(' ').Select(s => s.Trim(',', '?', '.', '!')).ToArray();

            string str = "Cat dog Cats dogs";//17
            // заменить Сat - kitty :  Cats - Kittys  в 2 спосодах 1. Используя if  2. Используя Replace
            var astr = str.Split(' ');

            for (var i = 0; i< astr.Length; i++)
            {
                if (astr[i] == "Cat")
                {
                    astr[i] = "Kitty";
                    
                }
                else if (astr[i] == "Cats")
                {
                    astr[i] = "Kittys";

                }
            }
            Console.WriteLine(str);
            var newStr = string.Join(" ", astr); // Join соеденение обратно в одну строку 
            Console.WriteLine(newStr);

            Console.WriteLine($"{astr[0]} {astr[1]} {astr[2]} {astr[3]}");
            

            string str2 = "Cat dog Cats dogs";
            var rep = str2.Replace("Cat", "Kitty");
            Console.WriteLine(str);
            Console.WriteLine(rep);



            #endregion urok4



            Console.ReadLine();
        }


    }   
}
