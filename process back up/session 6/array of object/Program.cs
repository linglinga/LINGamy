// Arrays1.cs
using System;

class TestArrays
{
    static void Main()
    {
        int[] numbers = new int[5]; // change "int" array to an object "numbers" could be any name.

        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;
        numbers[3] = 40;
        numbers[4] = 50;

        // Length - gets the total number of elements in all dimensions
        Console.WriteLine("Length is {0}", numbers.Length);
    }
}