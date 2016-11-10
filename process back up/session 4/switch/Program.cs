using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch // switch statment. is a C# exclusive tool.
                    // exclusive statements.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please select an option(1-5):");
            string str = Console.ReadLine();
            int x = int.Parse(str);

         
            switch (x) // switch (a type). lower case switch.
                        // (type) must be integer or string type.
                        // could be a 1 char type.
                        // (type) must match with case type.
            {           // within brackets, list all cases.
                        // consist of multiple cases with 1 default.
                        // each case must have a break. so it can end.
                case 1:
                    Console.WriteLine("option 1 is selected");
                    break;
                case 2:
                    Console.WriteLine("option 2 is selected");
                    break;
                case 3:
                    Console.WriteLine("option 3 is selected");
                    break;
                case 4:         // case 3 & 4 can be combined with only 1 console.WriteLine and 1 break;
                    Console.WriteLine("option 4 is selected");
                    break;
                case 5:
                    Console.WriteLine("option 5 is selected");
                    break;
                default:        // must have a default. if other cases don't happen, default must happen.
                                // if you enter option 10 which doesn't exist, this default will kick in.
                    Console.WriteLine("Option is not identified, please select a number again.");
                    break;
            }
            Console.ReadLine(); // show result
        }
    }
}
