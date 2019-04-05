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
/// сделать рекурсию для удаления обьектов
/// </summary>



namespace ConsoleApp1
{
    class Program
    {

        
        static public void Main(string[] args)
        {
            Maneger M1 = new Maneger("Igor", "ivanov", 30);

            SvoistvaManeger(M1);

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

            Console.WriteLine(M1.GetData(0));

            Wod(M1);

            Console.WriteLine(M1.GetData(0));

            Console.ReadKey();
        }
        static public void Wod(Maneger M)
        {
            Console.Write("Выберети индекс для удаления: ");
            int index = Convert.ToInt32(Console.ReadLine());
            Emploee E = M.getEmploeebyId(index);
            Console.Write($"Вы выбрали: \n {M.getEmploeebyId(index)} ?");
    
            Console.Write("Удалить? ");
            string udalit = Console.ReadLine();
            while (udalit.ToLower() != "y")
            {
                Wod((Maneger)E);
            }
        }

      static public void SvoistvaManeger(Maneger M)
      {
            string Exit = "y";

            while (Exit.ToLower() == "y")
            {
                Console.Write("Введите должность М / Е: ");
                string dolgnost = Console.ReadLine();

                Console.Write($"[{M.name}] Введите имя: ");
                string name = Console.ReadLine();

                Console.Write($"[{M.name}] Введите фамилию: ");
                string surname = Console.ReadLine();

                Console.Write($"[{M.name}] Введите возраст: ");
                int age = Convert.ToInt32(Console.ReadLine());

                if (dolgnost.ToLower() == "m")
                {
                    Maneger M2 = new Maneger(name, surname, age);
                    M.Add(M2);
                    SvoistvaManeger(M2);
                }
                else if (dolgnost.ToLower() == "e")
                {
                    Emploee E1 = new Emploee(name, surname, age);
                    M.Add(E1);
                    Console.WriteLine();
                }

                Console.Write($"Ввести еше работников для {M.name} ? ");
                Exit = Console.ReadLine();
            }
      }
    }
}
