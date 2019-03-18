using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Создать иирархию менеджер работник 
/// Maneger M1 1000
/// Emploee E1 500
/// Emploe E2 100
/// Должность имя зарплата
/// </summary>

namespace ConsoleApp1
{
    class Program
    {
       
        static public void Main(string[] args)
        {
            Emploee emploee = new Emploee();
            
            
           Console.WriteLine("Ведите имя менеджера: ");
           Maneger maneger = new Maneger { NameMendger = Console.ReadLine() };

            Console.WriteLine("Ведите кол-во работников менеджера: ");
            int quantityEmploee = Convert.ToInt32(Console.ReadLine());

            int[] massEmploee = new int[quantityEmploee]; // масив кол-ва работников
            if (quantityEmploee <= 0)
            {
                Console.WriteLine("У менеджера нет работяги");
            }
            for (int i = 0; i < massEmploee.Length; i++)
            Maneger M1 = new Maneger("Igor","ivanov",30);
            Emploee E1 = new Emploee("Vasia", "vasiliyev", 20);
            Emploee E2 = new Emploee("Sveta", "puper", 22);
            Emploee E3 = new Emploee("Nina", "truper", 33);
            M1.Add(E2);
            M1.Add(E3);

            Console.WriteLine(M1.TypDate()+"\n"+E1.TypDate());  
            for (int i =0; i<5;i++)
            {
                massEmploee[i] = i + 1;
                if (massEmploee[i] == i + 1)
                {

                    Console.WriteLine($"Ведите имя Работника {i + 1}: ");
                    string nameEmploee = Console.ReadLine();
                    emploee.voodEmploee(nameEmploee, quantityEmploee, i);

                }
                Console.WriteLine(M1.doo[i]);
            }
