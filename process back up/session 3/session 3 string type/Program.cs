
// String.cs
using System;

class TestString
{
    static void Main()
    {
        // strings are complex types. can manipulate a string.
        // strings can create logical statements. 

        // Assign "Hello" to str // str means storage.
        string str = "Hello"; // " " reads as a character. all spaces is important.
    
        // Concatentate str with " World" and
        // assign to str2
        string str2 = str + " World";

        // Compare two strings
        if (str2 == "Hello") //
        {
            Console.WriteLine("The strings are equal");
        }
        else
        {
            // Using the [] to access a Unicode
            // character
            char ch = str[0]; // Should be a 'H'
                              // ch = str[0] is take the 0 position of the string character.   is "H"
                              // ch = stor[1] is "e"
                              // means to get the str character of index 0 and store the string there
                              // and H is 72. always.
        }
    }
}