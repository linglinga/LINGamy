// File: while.cs
using System;

class TestWhile
{
    static void Main()
    {
        int x;
        int sum = 0;

        x = 1; // 1. variable has to be initialized before start of the loop.

        while (x < 1000) // 2. (...) the condition. snytex part.
                            // while the condition is met, it will continue in the loop.
                            // while loop must have: while, if statments, breaks, continue, and incrementer.
        { // start of the loop
            sum = sum + x; //seqentially add the number.

            if (sum > 20)
            {
                // exits the loop
                break; // must have a break.
            }

            if (sum == 10) //
            {
                // skips remainder of loop body
                continue; // continue back to the beginning of the loop while (x < 1000), skip the next console.WriteLine...
                // incrementor and console.writeline wont hapen.
            }

            Console.WriteLine("x is {0} and sum is {1}", x, sum);

            x++; // incrementor must happen before the next stop.
        } // end of the loop

        Console.ReadLine();
    }
}