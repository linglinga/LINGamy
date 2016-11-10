using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a person's full name:");

            string str = Console.ReadLine();

            // check if the name ends with Smith (not case sensitive)
            str = str.ToUpper(); // so set it to either ToUpper or ToLower.

            if (str.EndsWith(" SMITH")) //state the condition // To Do
            {
                Console.WriteLine("You found a Smith!");
            }
            else
            {
                Console.WriteLine("You didn't find a Smith.");
            }
            Console.ReadLine();


        }
    }
}

