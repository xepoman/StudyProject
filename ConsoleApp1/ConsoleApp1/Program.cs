using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

       static public void ReplaceKitty(string ishod, string ishod_zamena, string zamena )
        {

            string result = "";
            string[] ishodMass = ishod.Split(' ');
            for (int i = 0; i < ishodMass.Length; i++)
            {

                if (ishodMass[i].ToLower() ==  ishod_zamena.ToLower())
                {
                    result += zamena + " ";

                }
                
               else
                {
                    result += ishodMass[i]+" ";
                }
               
              
            }
             Console.WriteLine( result);

        }

        static void Main(string[] args)
        {
            ReplaceKitty("Cat dog Cats dogs","Cat dog","Kitty");
            
            


            Console.ReadLine();
        }

        // поиск под строки в строке
        // сортировки (написать пузырьком сортировку)  самому


    }   
}
