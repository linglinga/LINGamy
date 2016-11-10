
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
                             // from 1 type to another type still need to be explicite even if value is the same
                             // char is 2 bytes.
                             // in C# whenever you convert a bigger type to a smaller type. 
                             // you have to be explicit, because we are losing space or accuracy.
                             // casting or converting: (char)65 
                             // any integer is an number without a decimal.
                             // exclusively what you are converting. (char)

        // Convert a character value into an integer (8 bytes)
        long someLong = someChar; // small to larger = implicit. not lossing space. (char) not required.
                                  // can be explicite all the way through even it is not required. C# allows it.
                                  // 2 bytes of char to 8 bytes of integer.
                                  // what is assigned to is on the left side.
                                  // can be explicit at all times, good to learn the difference this way.
                                  // but be consistant. 
                                  // professinoal world don't like that.

        // Convert a character value into an integer (4 bytes)
        int someInt = someChar;

        // Convert a character value into a short (2 bytes)
        short someShort = (short)someChar; // need to be explicit. 
                                            // because it is 2 different types. char to integer.

        // Convert a character value into a byte (1 byte)
        byte someByte = (byte)someChar; // must be explicit. 2 different types and from 2bytes char to somebyte 1.
    }
}