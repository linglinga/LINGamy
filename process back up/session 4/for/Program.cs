// File: for.cs
using System;

class TestFor
{
    static void Main()
    {
        int sum = 0;
        int x;  // need to declare x here if we need to access it outside the loop

        for (x = 1; x < 1000; x++) 
            //(inititialize; condition; incrementor) use semicolons between statements.
            // 1. initialize: x = 1;
            // 2. check condition: x < 1000;
            // 3. execute statements below: { sum = sum + x:...}
            // 4. incrementer: x++
            // 5. check condition: x < 1000;
            // 6. execute statements below: { sum = sum + x:...}
                // for loop, you don't miss the incrementer.
                // while loop, you do skip the incrementer.
        {
            sum = sum + x;

            if (sum > 20)
            {
                // exits the for loop
                break;
            }

            if (sum == 10)
            {
                // skips remainder of loop body
                continue; // if sum == 10. then the complier will take you to incremeter x++ of the for loop.
            }

            Console.WriteLine("x is {0} and sum is {1}", x, sum);
        }
    }
}