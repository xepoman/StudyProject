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

        protected string name;
        protected string surname;
        protected int age;
        protected float stag;
        

        public Emploee(string name, string surname, int age)
        {
            Random r = new Random();
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.stag = r.Next(0, 50);
        }

        public virtual string GetData(int tab_count)
        {
            return this.name + " "
                + this.surname + " "
                + this.age + " "
                + "stag: " + this.stag + " "
                + this.GetType().Name
              //  + Salary.aaaa + " "
                + "\n";
        }




    }
}
