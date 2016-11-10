// File: Range.cs

using System;

class TestRange
{
    static void Main()
    {
        Console.WriteLine("byte.MinVal = {0}  byte.MaxVal = {1}", // { }: place holder must be in order: 0, 1, 2, 3... it is an index, a format issue, must be logical, in sequence.
            byte.MinValue, byte.MaxValue); // byte.MinValue, byte.MaxValue: could be 5, 10. this can be in different sequence.
                                            // 1st value: {0} which is 0 byte, then 2nd value: {1} which is 255 byte.
                                           // your value has to be in sequence. {0}, then {1}, then {2}. This is format sequence.
                                           // should have a logical sequence to it. and match the value with the same sequence.
                                           // MinVal: Minimum value. // MaxVal: Maximum value.
        Console.WriteLine("sbyte.MinVal = {0}  sbyte.MaxVal = {1}",
            sbyte.MinValue, sbyte.MaxValue);

        Console.WriteLine("short.MinVal = {0}  short.MaxVal = {1}",
            short.MinValue, short.MaxValue);
        Console.WriteLine("ushort.MinVal = {0}  ushort.MaxVal = {1}",
            ushort.MinValue, ushort.MaxValue);

        Console.WriteLine("int.MinVal = {0}  int.MaxVal = {1}",
            int.MinValue, int.MaxValue);
        Console.WriteLine("uint.MinVal = {0}  uint.MaxVal = {1}",
            uint.MinValue, uint.MaxValue);

        Console.WriteLine("long.MinVal = {0}  long.MaxVal = {1}",
            long.MinValue, long.MaxValue);
        Console.WriteLine("ulong.MinVal = {0}  ulong.MaxVal = {1}",
            ulong.MinValue, ulong.MaxValue);

        // Integerizing the char values so we can see the
        // numeric range otherwise you just see blanks and a ?
        Console.WriteLine("char.MinVal = {0}  char.MaxVal = {1}",
            (int)char.MinValue, (int)char.MaxValue);

        Console.WriteLine("float.MinVal = {0}  float.MaxVal = {1}",
            float.MinValue, float.MaxValue);

        Console.WriteLine("double.MinVal = {0}  double.MaxVal = {1}",
            double.MinValue, double.MaxValue);

        Console.WriteLine("decimal.MinVal = {0}  decimal.MaxVal = {1}",
            decimal.MinValue, decimal.MaxValue);

        Console.ReadLine();
    }
}