using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_git
{
    class Program
    {
        static void Main(string[] args)
        {
            cheval:
            Console.WriteLine("Hey! Qu'a tu à me dire aujourd'hui?");
            String txt = Console.ReadLine();
            Console.WriteLine("Tu viens d'écrire: " + txt);
            if (txt == "lol")
            {
                Console.WriteLine("LOL!");
                Console.WriteLine("MDR");
                Console.WriteLine("PTDR");
                Console.WriteLine("XD");
                Console.WriteLine();
            }
            if (txt != "stop")
            {
                goto cheval;
            }

        }
    }
}
