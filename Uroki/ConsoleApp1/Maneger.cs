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
        List<string> emploees = new List<string>();
      //  string[] emploees = new string[1];
      //  int lastNull = 0;
        int cell_number = 0;
        public Maneger(string name, string surname, int age)
            : base(name, surname, age)
        {

        }
        public void Add(string data)
        {
            /* if (emploees[emploees.Count-1] != null)
             {
                 this.lastNull = emploees.Count;
                 string[] temp_emploees = new string[emploees.Length+5];
                 for (int t = 0; t < this.emploees.Length; t++)
                 {
                     temp_emploees[t] = this.emploees[t];
                 }
                 this.emploees = temp_emploees;               
             }
             this.emploees[lastNull] = data;
             lastNull++;*/
            
            emploees.Add(data);
        }
         int Smash() // поиск на название менеджера
        {
            for (int i = emploees.Count - 1; 0 <= i; i--)
            {
                string[] word = emploees[i].Split(' ');
                for (int t = 0; t < word.Length; t++)
                {
                    if (word[t] == "Maneger")
                    {
                        return this.cell_number = i;
                    }
                    else if (word[t] == "Emploee")
                    {
                        return this.cell_number = i-1;
                    }
                }
            }
            return cell_number;
        }
        public override string GetData()
        {
            string output = base.GetData() + " \n";
                for (int i = 0; i < emploees.Count; i++) // сортировка
                {
                        string temp = this.emploees[i];
                        this.emploees[i] = this.emploees[Smash()];
                        this.emploees[cell_number] = temp;
                        output += "\t-- " + this.emploees[i] + "\n";
                }
            return output;
        }
    }
}
