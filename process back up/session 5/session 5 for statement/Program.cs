// File: for.cs
using System;

class TestFor
{
    static void Main()
    {
        int sum = 0;
        int x;  // need to declare x here if we need to access it outside the loop
        // int x; declaration of the variable.

        for (x = 1; x < 1000; x++) // use semicolons between statements
            // first: x=1; (initialization)
            // second: x < 1000;
            // fourth: x++
        {
            sum = sum + x;
            // it hits either one of the if statements below.

            if (sum > 20)
            {
                // exits the for loop
                break;
            }

            if (sum == 10)
            {
                // skips remainder of loop body
                continue;
            }

            Console.WriteLine("x is {0} and sum is {1}", x, sum);
            // third: for { } including Console.WriteLine.
        }
    }
}