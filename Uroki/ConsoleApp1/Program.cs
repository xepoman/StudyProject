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
            Maneger M1 = new Maneger("Igor", "ivanov", 30);
            Emploee E1 = new Emploee("Vasia", "vasiliyev", 20);
            Emploee E2 = new Emploee("Sveta", "puper", 22);
            Emploee E3 = new Emploee("Nina", "truper", 33);
            M1.Add(E1.GetData());
            M1.Add(E2.GetData());

            Console.WriteLine(M1.GetData());
            
            Console.ReadKey();
        }

    }
}
