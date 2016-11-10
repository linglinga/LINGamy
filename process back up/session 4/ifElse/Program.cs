// File: ifelse.cs

using System;

class TestIfClass
{
    static void Main()
    {
        int x = 5;

        if (x == 5) //if, else is block 1.
        {
            Console.WriteLine("x is equal to 5"); // this will run 1st.
        }
        else
        {
            Console.WriteLine("x is not equal to 5"); // skip
        }

        if (x > 5) // if, else if, else if, else is block 2.
        {
            Console.WriteLine("x is greater than 5"); // skip
        }
        else if (x > 4)
        {
            Console.WriteLine("x is greater than 4"); // this runs 2nd.
        }
        else if (x > 3)
        {
            Console.WriteLine("x is greater than 3"); // skip. this wont run because x > 4 already ran.
        }
        else
        {
            Console.WriteLine("x is less than or equal to 3");
        }

    }
}