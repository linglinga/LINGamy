// Formatting.cs
using System;

class TestMain
{
    static void Main()
    {
        Console.WriteLine("Left justified : [{0,-10}]", 15); // give you 10 spaces but has to be left justified.
        Console.WriteLine("Right justified: [{0,10}]", 22); // [10 spaces to display the value 22, remaining are empty spaces]

        Console.WriteLine("Currency: {0:C}", 88.8); // Currency: $88.00
        Console.WriteLine("Hex: {0:X}", 1203); // Hex: 4BC
        Console.WriteLine("Fixed: {0:F3}", 1234.56789); // give you with Fixed 3 decimmal and that's it. so number will be 1234.568

        Console.ReadLine();
    }
}