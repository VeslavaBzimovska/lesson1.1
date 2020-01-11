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
            Console.WriteLine(string.Format("Hello {0}", name));
            Console.ReadLine();

        }
    }
}
