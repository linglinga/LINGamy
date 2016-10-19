using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3 // New HomeWork3
                    // Write a program that calculates factorial of an integer x given by the user.  
                    // Please enter a small integer. 
                        // (large factorials: 20! 50! etc. use BigInteger) 
                        // (small integer use long or int) 
                    // 4 factorial "4!": 4*3*2*1 = 24.  factorial * decrement number (decreased number)
{
    class CalFactorial // give the class a name.
    {
        static void Main()
        {
            // 1. ask user to input a small integer for the factorial calculation
            Console.WriteLine("Please input a small integer for the factorial calculation: ");

            // 2. declare the string, read it and store it back to the string.
            string str = Console.ReadLine();

            // 3. convert the number in the string format to the numeric format.
            int x = int.Parse(str);

            // 4. do the calculations for the factorial calcualtion of x.
            int factorial = 1;          // factorial is assigned as 1 (whole number).

            while (true)                
            {
                Console.Write(x);       // Console Write on screen the input number x. based on below statement.
                if (x == 1)             // if the enerted number x is equal to 1 (whole number).
                {
                    break;              // leave this while loop. Do not need to check input anymore.
                }
                Console.Write(" * ");   // Console Write on screen " result of: (x--;) * (the formular below: fatorial *= x) ".
                factorial *= x;         // factorial = factorial * entered number x in decremented number format. 
                x--;                    // postfix decrement operation: value x of the operand before it has been decremented. (same as input number x)
            }

            // 5. convert the result to string
            // can be happened automatically with console.write or console.writeLine to show on the screen
            Console.WriteLine(" = {0}", factorial);
                                        // console write on screen the formular above: 
                                        // " * " = (result instead of the place holder {0}), factorial"

            Console.ReadLine();         // to hold up the console, always leave this in here.


        }
    
    }
}
