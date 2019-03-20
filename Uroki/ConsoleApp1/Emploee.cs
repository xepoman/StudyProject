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

        public Emploee(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public virtual string GetData()
        {
            return this.name + " " + this.surname + " " + this.age + " " + this.GetType().Name;
        }




    }
}
