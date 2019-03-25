using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    class Maneger : Emploee
    {
        List<Emploee> emploees = new List<Emploee>();      
        public Maneger(string name, string surname, int age)
            : base(name, surname, age)
        {

        }
        public void Add(Emploee e)
        {
            emploees.Add(e);
        }
         
        public override string GetData(int tab_count)
        {
            
            string output = base.GetData(tab_count);
            for (int i = 0; i < emploees.Count; i++)
            {
              output += "\t--- "  + emploees[i].GetData(
                    emploees[i].GetType().Name == "Maneger" ? 
                    tab_count+1:
                    tab_count
                    );  
                
            }
            return output;
        }
    }
}
