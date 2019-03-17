using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Maneger
    {


        string nameMendger;

        public string NameMendger
        {
            get { return nameMendger; }
            set { nameMendger = value; }

        
        }


        public void Display()
        {
            Console.WriteLine($"Имя Менеджера: {NameMendger}");
        }
       


    }
}
