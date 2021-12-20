using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_5
{
    /// <summary>
    /// /// <summary>
    /// Scrieţi o functie care să calculeze factorialul unui număr întreg n
    /// </summary>
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
                int n, i;
                long fact = 1;
                Console.Write("Introducdeti numarul n dorit:  ");
                n = int.Parse(Console.ReadLine());

                for (i = 1; i <= n; i++)
                    fact *= i;
                Console.WriteLine("{0}! = {1}", n, fact);
                Console.ReadLine();
            
        }
    }
}
//am folosit instructiunea "for" pentru a calcula factorialul. Pentru a face inmultirea numerelor
// pornind de la valoarea 1 pana la valoarea lui n.