using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApp1
{
    class Emploee 
    {
       string[] massEmploe; // ошибка так как он первую переменую не запоминает .. null

        

        

        public void voodEmploee(string name, int quantityMass, int Numbercikl)
        {
           massEmploe = new string[quantityMass];  
            
              massEmploe[Numbercikl] = name;

            
           
        }


        
        public void Display(int quantityEmploee)
        {
            if (quantityEmploee <= 0) return;
            for (int i=0; i<massEmploe.Length; i++ )
            {
                Console.WriteLine($"Имя работника {i+1}: {massEmploe[i]}");
            }

           
        }
    }
}
