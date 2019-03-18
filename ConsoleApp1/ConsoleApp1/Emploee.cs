using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApp1
{
    class Emploee 
    class Emploee
    {
       string[] massEmploe; // ошибка так как он первую переменую не запоминает .. null

        

        
        protected string name;
        protected string surname;
        protected int age;

        public void voodEmploee(string name, int quantityMass, int Numbercikl)
        public Emploee(string name, string surname, int age)
        {
           massEmploe = new string[quantityMass];  
            
              massEmploe[Numbercikl] = name;

            
           
            this.name = name;
            this.surname = surname;
            this.age = age;
        }


        
        public void Display(int quantityEmploee)
        {
            if (quantityEmploee <= 0) return;
            for (int i=0; i<massEmploe.Length; i++ )
        public string TypDate()
            {
                Console.WriteLine($"Имя работника {i+1}: {massEmploe[i]}");
            return this.name + " " + this.surname + " " + this.age + " " + this.GetType().Name;
            }
        

        

           
        }
    }
}
