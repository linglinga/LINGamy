
// File: bool.cs

using System;

class TestBool
{
    static void Main()
    {
        bool flag = true;

        flag = false;

        int x = 1; // if change to x =1; then flag = (x == 1); will be false.

        // Assign flag to true or false
        // depending on whether x is
        // equal to 1.
        flag = (x == 1);
    }
}