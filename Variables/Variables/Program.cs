using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            if (name == "Veslava")
            {
                Console.WriteLine("Nice to see you {0}", name);
            }
            else
            {
                Console.WriteLine("Unkown user");
            }
            Console.ReadLine();
            if (name == "Veslava")
            {
                string pasisveikinimas = "labas";
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(pasisveikinimas);
                }
                Console.ReadLine();
            }
        }
    }
}
