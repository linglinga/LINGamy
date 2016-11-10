// Arrays1.cs
using System;
// arrays allows you to create a collection.
// store a series of numbers in a form of collection.
// once its stored: it has a size, length, height, level (like a condo tower)
// stores in a unique way: a stack of numbers, array of numbers.
class TestArrays
{ // C#, array has access to its index, length & properties.
    static void Main()
    {
        int[] numbers = new int[5]; // declaration of the array.
        // creates a space in the memory with 5 spots reserved. Can only accepts integers.
        // defining an array of type integer size is 5 (length is 5).
        // type: int, [] = array. name: numbers.
        // must use "new" [how many]. (height of the condo tower)
        // new = allocate an initialize.
        // array can be as large as 2GB.
        // [5] is the maximum. 
        // arrays always have a maximum, not an open ended collections. always fixed with upper and lower bound.
        // dynamic array: is open ended. open ended collections. It is not an array.

        // assigning/ocuppying the array.
        numbers[0] = 10; // index 0 by default, all array should start with 0. Array level.
        // number [0]: is first spot of the array. (length is 1)
        // assigning the first spot or 1st level of condo with 10 people.
        // have to start with 0 for array.

        numbers[1] = 20; // value is assigned 20.
        // numbers [1] = 20; is a single demesional array.
        // 2 demensional array: 
        // numbers [,] numbers = new int[5,5];
        numbers[2] = 30; // do not have to assign all the values for numbers [2,3,4,5], no, but it will result in 0.
        numbers[3] = 40; // can only assign odd or even numbers. it does not require assigning in sequence.
        // this is hard coding, defining the array.
        numbers[4] = 50; // number[4]: is the last spot, fifth spot of the array. (length is 5)
        // do not need to fill out all value, or in sequence, can only be even, or odd.

        // Length - gets the total number of elements in all dimensions
        Console.WriteLine("Length is {0}", numbers.Length);
        // numbers is a type of array. with '.' it gives you options of 
        // upper bound (4), lower bound (0), length, etc. in drop down menu.
        // in the drop down menu: 
        // the icon ranch: is a type property, without (). they return a value or give a value. Methods has ().

    }
}