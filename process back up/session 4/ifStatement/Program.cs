// File: if.cs

using System;

class TestIfClass
{
    static void Main()
    {
        int x = 5;
        int y = 2;

        if (x == y) // if x & y is equal. A boolean statment with 1 statement: true/false. 
            // not true, then it will not read inside { }, jump to next statement.
        {
            Console.WriteLine("x is equal to y");  
        }

        if (x != y) // != means "not equal".
        {
            Console.WriteLine("x is not equal to y");
        }

        if (x > 5) // is x larger than 5?
        {
            Console.WriteLine("x is greater than 5");
        }

        if (x >= 5) // is x greater or equal to 5? (yes, so run script { })
        {
            Console.WriteLine("x is greater than or equal to 5");
        }

        if (y < 2) // is y less than 2? 
        {
            Console.WriteLine("y is less than 2");
        }

        if (y <= 2) // is y les than or equal to 2?
        {
            Console.WriteLine("y is less than or equal to 2");
        }

    }
}