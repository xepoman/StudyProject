using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Maneger : Emploee
    {
        string[] emploees = new string[1];
        int lastNull = 0;
        public Maneger(string name, string surname, int age)
            : base(name, surname, age)
        {

        }

        public void Add(string data)
        {
            if (emploees[emploees.Length-1] != null)
            {
                this.lastNull = emploees.Length;
                string[] temp_emploees = new string[emploees.Length+5];
                for (int t = 0; t < this.emploees.Length; t++)
                {
                    temp_emploees[t] = this.emploees[t];
                }
                this.emploees = temp_emploees;               
            }
            this.emploees[lastNull] = data;
            lastNull++;
        }
        public override string GetData()
        {
            string output = base.GetData()+ "\n";
            for (int i=0;i<this.lastNull;i++)
            {
                output += "\t-- "+this.emploees[i]+"\n"; 
            }
            return output;
        }
    }
}
