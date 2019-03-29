using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*cтаж >5 =>*0.5
* возраст > 50 =>*2
* менеджер =>*0.3
*/

namespace ConsoleApp1
{
    class Salary
    {
        const float stavka = 4000.0f;
        
        static public float getSalary(Emploee e)
        {
            float zp = 0.0f;
            if (e.GetType().Name == "Maneger")
            {
                zp = stavka + stavka * 0.3f;
            }
            else
            {
                zp = stavka;
            }
            if(e.age > 50)
            {
                zp += stavka * 2f;
            }
            if(e.stag > 5)
            {
                zp += stavka * 0.5f;
            }

            return zp;
        }

    }
}
