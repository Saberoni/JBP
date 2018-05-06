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
            // This is a comment.
            if(yourName == "God")
            {
                Console.WriteLine("My Lord God! How may we serve?");
            }
            else
            {
                /*
                    comment block
                */
                Console.WriteLine("What can I do for you {0}?", yourName);
            }
            

            int x = 15;
            int y = 6;
            x %= y;
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
