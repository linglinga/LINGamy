using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_5_classwork_2
{ // show the minimum and maximum of an array using foreach.
    class Program
    {
        static void Main(string[] args)
        {
            // set up an array
            int[] aNum = new int[] { 0, 2, 5, 100, -1, 4, 8, -5 };
            // array name: aNum.
            // minimum array: -5.
            // maximum array: 100.
            
            // try to use comparisant (looping: foreach),  instead of sorting.
            // shorter or taller: use < or > comparisant.

            // declare a Min and a Max.
            int Min;
            int Max;

            // Assume the first value in the 
            // array is the Min and Max value
            // then work from there.
            Max = aNum[0]; // i picked on the first number in the group for Max
            Min = aNum[0]; // i picked on the first number in the group for Min
            // can pick on other index, doesn't have to be the first number [0]. could be [4].

            // need to create a looping method to go through the Min and Max
            foreach (int x in aNum)
            {
                // find the Min
                if (x < Min) // x is less than Min
                {
                    Min = x;
                }

                // find the Max
                if (x > Max) // x is greater than Max
                {
                Max = x;
                }
            } // end of foreach loop

            // show the Min and Max results
            Console.WriteLine("The Minimum value is {0}", Min);
            Console.WriteLine("The Maximum value is {0}", Max);

            // hold up the cosole to see the result
            Console.ReadLine();
        }
    }
}
