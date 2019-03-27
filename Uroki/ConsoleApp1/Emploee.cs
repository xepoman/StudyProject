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
        static protected int age;
        static protected float stag;
        static protected string dolgnost;
        Random r = new Random();
        Salary sal1 = new Salary(age, stag, dolgnost);

        public Emploee(string name, string surname, int age1)
        {
            this.name = name;
            this.surname = surname;
            age = age1;
            stag = r.Next(age);
        }

        public virtual string GetData(int tab_count)
        {
            dolgnost = GetType().Name;
            return this.name + " "
                + this.surname + " "
                + age + " "
                + "stag: " + stag + " "
                + this.GetType().Name +" "
                + "salary: " + sal1.getSalary(sal1) + " "
                + "\n";
        }




    }
}
