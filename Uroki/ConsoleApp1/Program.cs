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
/// </summary>



namespace ConsoleApp1
{
    class Program
    {
         

        static public void Main(string[] args)
        {
            Maneger M1 = new Maneger("Igor", "ivanov", 30);
            Maneger M2 = new Maneger("serega", "sergeev", 34);
            Maneger M3 = new Maneger("niga", "abama", 34);
            Emploee E1 = new Emploee("Vasia", "vasiliyev", 20);
            Emploee E2 = new Emploee("Sveta", "puper", 22);
            Emploee E3 = new Emploee("Nina", "truper", 33);
            M1.Add(E1.GetData());
            M1.Add(E2.GetData());
            M1.Add(M2.GetData());
            M1.Add(M3.GetData());

            Console.WriteLine(M1.GetData());
            Console.ReadKey();
        }

    }
}
