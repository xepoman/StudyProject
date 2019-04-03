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
        public string getEmploeebyId(int index)
        {
            if(index>0)
            {
                getEmploeebyId(index - 1);
            }
            return emploees[index].GetType().Name;
        }
        
        public void Delete(int index)
        {
            emploees.RemoveAt(index);
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
              output += Tabul('\t', tab_count) + $"[{i}] "  
                    + emploees[i].GetData(
                    emploees[i].GetType().Name == "Maneger" ? 
                    tab_count+1:
                    tab_count
                    );  
                
            }
            return output;
        }

        public string Tabul(char ch, int count)
        {
            string tabul = "";
            for (int i =0; i<count; i++)
            {
                tabul += ch;
            }
            return tabul;
        }
    }
}
