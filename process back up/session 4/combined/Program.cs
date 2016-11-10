// File: compound.cs

using System;

class TestIfClass
{
    static void Main()
    {               // combining logical statements = conditional statements.
        int x = 5;
        int y = 2;
        // separate if statements without else, so it will go from one if to the next if.
        if (x > 1 && y > 1) // && is AND statement
        {
            Console.WriteLine("x is greater than 1 AND y is greater than 1"); // execute 1.
        }

        if (x > 5 || y < 4) // || is OR statement
        {
            Console.WriteLine("x is greater than 5 OR y is less than 4"); // execute 2. bc y < 4 is a true statement.
        }

        if ((x > 2 && y < 3) || x == 2) // combine AND / OR together
        {
            Console.Write(" (x is greater than 2 AND y is less than 3)"); // exectue 3. bc x > 2 & y < 3. even x == 2 is false.
            Console.WriteLine(" OR (x is equal to 2)");
        }
    }
}