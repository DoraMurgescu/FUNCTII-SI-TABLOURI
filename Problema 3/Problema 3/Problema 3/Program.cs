using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3
{
    /// <summary>
    /// . Scrie o metodă care primește ca parametru un număr natural x și apoi afișează: 
    /// -cifrele numărului(în ordine inversă)
    /// -suma cifrelor
    /// n == 21304
    /// Cifrele numărului sunt: 4, 0, 3, 1, 2,
    ///suma cifrelor este: 10
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int S = 2 + 1 + 3 + 0 + 4;        //am initializat S cu o valoare.
            Console.Write("Introdceti numarul n (pt. n= 21304): ");
            n = int.Parse(Console.ReadLine());

            while (n != 0)                    // am scris algoritmul inversului numarului dat
            {
                Console.Write(n % 10 + " ");

                n = n / 10;
            }
            for (int i = 1; i <= n; i++)     // am facut suma
            {
                S = i * 2;
            }
            Console.WriteLine($"S = i * 2 + i * 1 + i * 3 + i * 0 + i * 4 este: {S}");  // Am scris numarul ca pe o inmultire a fiecarei cifre.
            Console.ReadLine();
        }
    }
}
