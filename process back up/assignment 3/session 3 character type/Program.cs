
// File: Char.cs
using System;

class TestChar
{
    static void Main()
    {
        // Assign a single character 'a' to chSomeChar
        char someChar = 'a'; // 2 bytes

        // Convert an integer value (65) into a character
        someChar = (char)65; // 65 is integer type by default. 4 bytes. 
                             // from 1 type to another type still need to be explicite even if value is the same.
                             // in C# whenever you convert a bigger type to a smaller type. 
                             // you have to say explicite.
                             // exclusively what you are converting. (char)

        // Convert a character value into an integer (8 bytes)
        long someLong = someChar; // small to larger = implicite. not lossing space. (char) not required.
                                  // can be explicite all the way through even it is not required. C# allows it.
                                  

        // Convert a character value into an integer (4 bytes)
        int someInt = someChar;

        // Convert a character value into a short (2 bytes)
        short someShort = (short)someChar; // need to be explicite

        // Convert a character value into a byte (1 byte)
        byte someByte = (byte)someChar;
    }
}