// Session 5 - In Class Exercise No. 1
// Write a program that calculates the average of numbers given by the user.

using System;

class Average
{
    static void Main()
    {
        // define a variable for summation. (outside of for loop)
        float fsum = 0.0f; // starting point 
        // can use double, int, decimal, or others, but format is the same.

        // define a variable for average. (outside of for loop)
        float favg;

        // start up the for loop: allow for 10 entries by the user
        for (int x = 1; x <= 10; x++) // initialize: x = 1; condition: x <= 10;
            // int x = 1: declaring and initializing at the same time.
        {
            // ask the user to give you a number
            Console.Write("Please enter number {0} of 10:", x);

            // read and store the given number
            string strnum = Console.ReadLine();

            // convert the string type to numeric type
            float n = float.Parse(strnum);

            // sum up the number as given
            fsum = fsum + n;

        } // end of the for loop

        // after summing them up within the loop, find the average
        favg = fsum / 10;

        // show the result on the console
        Console.WriteLine("The average of the given numbers is {0}", favg);
        Console.ReadLine(); // hold up the console to see the result
    }

}