// File: foreach.cs
using System;

class TestForeach
{ // forEach: looping only applicable to arrays or collections only.
    static void Main()
    {
        int[] myarray = new int[] { 2, 4, 6, 8, 10, 15, 20, 30, 100 };
        // declaring, initializing and assigning an array.
        // declare the size inside { }.
        // { 9 numbers total= 9 lengths. first index(2) is 2, last index(100) is 8};
        // it will automatically assign it into [ ].
        // declare the type: int[] myarray = new int[] 

        
        int sum = 0; // sum is intitialized.

        // add these numbers with a looping. 2 + 4 + 6 + 8 + 10 + 15...
        // use foreach.
       
        foreach (int x in myarray) // no semicolons. 
            // for each int x in myarray.
            // int[] myarray & (int x in myarray) the name has to match. myarray/numbers.
            // foreach can not change things, can only read.
            // not design to alter anything. but forloop can.
            // int x: declaration.
            // for each int x in my array, do the following formula.
            // sequence: 1.foreach  2.myarray   3.in    4.int x.
        {
            sum = sum + x; // x can be anything you want.
            // x will take on the 1st value of the array, at index 0 then take on the value 4, then 6, 8, etc.
            // foreach loop, C# already know the length, start, and end. 
            // unlike other for loop.
            // can only apply to a defined array or collections.
            // can never be used to alter an array. no expand, strink an array.
            // forloop can only read and deliver the results of an array.
        }

        Console.WriteLine("sum is {0}", sum);
    }
}