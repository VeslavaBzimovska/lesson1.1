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
            string userName = "a";
            ShowHelloWorld();
            Console.ReadLine();
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            UserAuthorization(userName, name);
            Console.ReadLine();
            Greetings(userName, name);
            Console.ReadLine();
        }

        private static void UserAuthorization(string userName, string name)
        {
            if (name == userName)
            {
                Console.WriteLine("Nice to see you {0}", name);
            }
            else
            {
                Console.WriteLine("Unkown user");
            }
        }

        private static void ShowHelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        private static void Greetings (string userName, string name )
        {
            if (name == userName)
            {
                string pasisveikinimas = "labas";
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i + 1 + ". " + pasisveikinimas);
                }
            }
        }
    }
}
