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
        Random r = new Random();

        public Emploee(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public virtual string GetData(int tab_count)
        {
            this.stag = r.Next(age);
            return this.name + " "
                + this.surname + " "
                + this.age + " "
                + "stag: " + this.stag + " "
                + this.GetType().Name +" "
                + "salary: " + Salary.getSalary(this.age, this.stag, GetType().Name) + " "
                + "\n";
        }




    }
}
