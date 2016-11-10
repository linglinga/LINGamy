using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_4_looping_and_arrays
{
    class CalFactorial // give the class a name.
    {
       
        static void Main() // console starts here.
        {
            // 1. ask the user to enter a small number of factorials to display.
            Console.Write("Please input an integer smaller than 200 for the factorial calculation: ");

            // 2. declare the string, read it and store it back to the string.
            string str = Console.ReadLine();

            // 3. convert the number in the string format to the numeric format.
            int n = int.Parse(str);
            
            // 4. do the calculations for the factorial calculation of x using (for loop).
            int factorial = 1; // factoiral is assigned as 1 whole number.

            for (int i = 1; i <= n; i++)    // 1. int i = 1 is declare and initialize.
                                            // 2. i <+ n; is the condition. if true go to 3.
                                            // 4. incrementor.
                                            // 5. check i <= n; the condition. if true go to 3, 4, then 5 again.
            { 
                factorial = factorial * i;  // 3. calculate.
            }
            Console.WriteLine("{0}! = {1}", n, factorial); //6. if i <= n; is false, this will run.
            
            Console.ReadLine(); // to hold up the console.
            
        } // end of main
        

    } // end of class CalFactorial
   
    
}
