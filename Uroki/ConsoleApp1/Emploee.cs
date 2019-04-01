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

        public string name;
        protected string surname;
        public int age;
        public float stag;
        Random r;
        

        public Emploee(string name, string surname, int age)
        {
            r = new Random();
            this.name = name;
            this.surname = surname;
            this.age = age;
            stag = r.Next(age);
        }

        public virtual string GetData(int tab_count)
        {
            return this.name + " "
                + this.surname + " "
                + age + " "
                + "stag: " + stag + " "
                + this.GetType().Name +" "
                + "salary: " + Salary.getSalary(this) + " "
                + "\n";
        }




    }
}
