using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    /// <summary>
    /// Scrieţi o funcţie care să transforme un unghi exprimat în radiani în valoarea sa exprimată în 
    /// grade şi una care să facă transformarea inversă.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti o valoare in radiani:");
            Program rez1 = new Program();
            rez1.radiani1();
            Console.WriteLine("Introduceti o valoare in grade:");
            Program rez2 = new Program();
            rez2.radiani2();
        }

        private void radiani2()
        {
            int grade;
            grade = int.Parse(Console.ReadLine());
            Console.WriteLine($"Valoarea in radiani a {grade} este {(grade * Math.PI) / 180} radiani");
            Console.ReadLine();
        }

        private void radiani1()
        {
            int r;
            r = int.Parse(Console.ReadLine());
            Console.WriteLine($"Valoarea in grade a {r} este {(r * 180) / Math.PI} grade");
            Console.ReadLine();
        }
    }
}
///Am scris pe consola cerintele cerute, anume: valaore in radian si in grade. Am generat doua metode, anume: radiani1 (l-am declara pe r aici,
///l-am citit am scris pe consola formula pentru a afisa rezultatul final in grade) iar
///radiani2, am procedat la fel, am declara variabila grade, am citit-o pe consola, am scris mesajul pentru unghiul exprimat in radiani, 
/// un am atasat si formula pentru a-mi da rezultatul exprimat in radiani.
