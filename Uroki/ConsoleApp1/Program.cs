using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
/// <summary>
/// Создать иирархию менеджер работник 
/// Maneger M1 1000
/// Emploee E1 500
/// Emploe E2 100
/// Должность имя зарплата
/// 
/// создать добавление бесконечных менеджеров и работников
/// </summary>



namespace ConsoleApp1
{
    class Program
    {
         

        static public void Main(string[] args)
        {
            Maneger M1 = new Maneger("Igor", "ivanov", 30);
            string exit = "";
            while (exit != "1")
            {
                Console.Write("Введите имя: ");
                string name = Console.ReadLine();

                Console.Write("Введите фамилию: ");
                string surname = Console.ReadLine();

                Console.Write("Введите возраст: ");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите должность М / Е: ");
                string dolgnost = Console.ReadLine();
                if(dolgnost == "М")
                {
                    Maneger M2 = new Maneger(name, surname, age);
                    M1.Add(M2);

                    Console.Write("Введите работника М2 имя: ");
                    name = Console.ReadLine();

                    Console.Write("Введите работника М2 фамилию: ");
                    surname = Console.ReadLine();

                    Console.Write("Введите работника М2 возраст: ");
                    age = Convert.ToInt32(Console.ReadLine());

                    Emploee E2 = new Emploee(name, surname, age);
                    M2.Add(E2);
                }
                else if(dolgnost == "Е")
                {
                    Emploee E1 = new Emploee(name, surname, age);
                    M1.Add(E1);
                    Console.WriteLine("работник создан");
                }
                Console.WriteLine("Ведите 1 если хотите выйти: ");
                exit = Console.ReadLine();
            }
            Console.WriteLine(M1.GetData(1));


            /*  Maneger M2 = new Maneger("serega", "sergeev", 34);
              Maneger M3 = new Maneger("petya", "abama", 54);
              Emploee E1 = new Emploee("Vasia", "vasiliyev", 20);
              Emploee E2 = new Emploee("Sveta", "puper", 22);
              Emploee E3 = new Emploee("Nina", "truper", 33);
              M1.Add(E1);
              M1.Add(E2);
              M1.Add(M2);
              M1.Add(M3);
              M2.Add(E3);*/


            Console.ReadKey();
        }

    }
}
