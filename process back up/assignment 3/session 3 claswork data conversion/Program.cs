using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

                                        // IT FDN105B session 3. My First Class Exercise

namespace session_3_claswork_data_conversion
{
    class Program
    {
        static void Main()              // for complier to start.
        {
            // 1. ask user to input a number for the console.
            Console.Write("Please type an integer value for x: ");

            // 2. read the number from console, and store it into a string type.
            string str;                 // declare the string. store the string
            str = Console.ReadLine();   // read it and store it.

            // 3. convert the number that is in the string format to the numeric format.
            int x = int.Parse(str);

            // 4. do the calculations for the formula (5*x*x + 6) 
            int iResult = (int)((5 * x * x) + 6);   //faded (int) means it is implicit. and as an explicit developer i put (int) anyways.

            // 5. convert the result to string 
            // can be happend automatically with console.write or console.writeline to show on the screen
            Console.WriteLine("The calcuated value for 5x^2+6 is {0}", iResult);

            Console.ReadLine();         // to hold up the console, always leave this in here.
        }
    }
}
