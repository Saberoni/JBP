using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your Name?");

            string yourName = Console.ReadLine();

            if(yourName == "God")
            {
                Console.WriteLine("My Lord God! How may we serve?");
            }
            else
            {
                Console.WriteLine("What can I do for you {0}?", yourName);
            }
            Console.ReadLine();
        }
    }
}
