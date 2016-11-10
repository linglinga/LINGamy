// File: Boxing.cs
using System;

class TestBox
{
    static void Main()
    {
        int myInt = 20; // assigning an int to a value 20 to the integer.

        // 1. (boxing)
        // myObj now contains the integer
        // value of 20.
        object myObj = myInt;
        // object: declare the object type
        // name: myObj
        // object tuype: object(int). (int) is a box, not a variable.
        // assign a value: myInt // this process is called boxing an object.
        // the value: is myInt
        

        // 2. myObj now contains 2001
        myObj = 2001;

        // 3. (unboxing)
        // myOtherInt contains the value
        // contained in myObj.
        int myOtherInt = (int)myObj; // (int) unboxing. have to say what types it will be pulling out.
        // to get the value of "myObj".
        // object is on the right hand side and trying to get the value out of that: always unboxing.

        // 4. (unboxing)
        // if you wanted to unbox myObj
        // into a double you FIRST need
        // to unbox it as an int and then
        // convert it to a double.
        double dbl = (double)(int)myObj; //is this casting or unboxing? 
        // myObj: an object
        // double: variable type called double.
        // (int)myObj: the type is the integer in the object. 
        // (int) unboxing
        // this is unboxing. we are not converting.
        // the value is an int.
        // int to double is from big to small.
        // (double): casting
        // this is unboxing and casting implicitly.
    }
}