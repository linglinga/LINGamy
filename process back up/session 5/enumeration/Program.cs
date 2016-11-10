// File: enum.cs 
using System;

enum MonthNames // lets you create a group name for the enumeration of data. 
    // whole numbers only.
    // can combine switch statement with enum.
    // allows me to have a name and number associated to it.
    // enum must be defined before you use it. Could inside the class or outside the class.
    // outside the class: so other classes has access to it.
    // inside the class: only the class that contain it has access to it. (can create a library and access it)
{
    January = 1, // set the value of 1 for january. Auto: feb = 2, march = 3...
    // can manually enter value to each and use "," not ";"
    // can be in the same line, but better if they have its own line.

    February,
    March,
    April
}

class Test
{
    static void Main()
    {
        MonthNames month; // declaration of an enum

        month = MonthNames.March; // initializing the enum. similar to x = 1;

        if (month == MonthNames.January) // logical statement.
        {
            Console.WriteLine("It's still Winter");
        }
        else if (month == MonthNames.February)
        {
            Console.WriteLine("It's still Winter");
        }
        else if (month == MonthNames.March)
        {
            Console.WriteLine("It's Spring");
        }

        Console.WriteLine("Month is {0} and its integer value is {1}",
            month, (int)month); // {0} is the name. {1} is the value of the name.

        Console.ReadLine(); // holds up the console, always have this.
    }
}