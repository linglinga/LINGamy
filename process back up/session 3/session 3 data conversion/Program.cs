// File: DataConversions.cs

using System;

class Test
{
    static void Main()
    {
        string strVal; // string type: named strVal
        int intVal;     // integer type: intVal.
        double dblVal;  // double type: dblVal

        // strVal must "look" like an integer
        // if it doesn't the Parse() function will fail.
        strVal = "45"; // can store a string into a string type variable.
        // "45": 45 is a string. to use for calucation, you need that to be numerical.

        // try to "Parse" the string into an integer/numberic.
        intVal = int.Parse(strVal); // convert strVal by using int.Parse 
                                    // and this value is called intVal.
                                    // how it is converted: learn it from an algorithum class.

        strVal = "45.2"; // new strVal of 45.2 has been entered.
        dblVal = double.Parse(strVal); // convert string type to a double: numeric.
        // could be decimal.Parse, // float.Parse,
        // decimal is always better when dealing with money, scientific research.
        // when double is cut out some decimal, you don't know what happened to these numbers.
        // but no real acuracy because numbers will get chopped off at some point.

        // Converting ANY type to a string is trival
        // because EVERY object supports ToString()
        strVal = intVal.ToString(); // from numeric to string.
        // .ToString(): meams its a function with ().
        // strVal: store it back to strVal.
    }
}
