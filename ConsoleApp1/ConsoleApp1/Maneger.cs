using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Maneger
    class Maneger : Emploee
    {


        string nameMendger;

        public string NameMendger
       public string[] doo = new string[5];
       
        public Maneger(string name,string surname,int age)
            : base(name,surname,age)
        {
            get { return nameMendger; }
            set { nameMendger = value; }

        
        }


        public void Display()
        public void Add(Emploee newEmploee)
        {
            Console.WriteLine($"Имя Менеджера: {NameMendger}");
        }
       

            if(doo ==null )
            {
                this.doo = new string[10];
            }
            for (int i = 0; i<doo.Length;i++)
            {

                if (doo[i] == null)
                {
                    this.doo[i] = newEmploee.TypDate();
                    break;
                }
                
            }

        }
        
    }
}
