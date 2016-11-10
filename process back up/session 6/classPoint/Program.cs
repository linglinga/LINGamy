// File: Point2.cs
using System;

class Point
{
    private int X; 
    private int Y;

    // public Constructor
    public Point(int x, int y) //2. this X & Y is forced to be 0 by complier. part of hte instanitation process. 
    {
        X = x; // initialize based on new parameters passed. X = 10
        Y = y; // Y =20
        // fields: Cap X Y. (major componenet of the class)
        // Parameters: small x y. (just numbers to be pass to method or 
    }

    public int GetX()
    {
        return X;
    }

    public int GetY()
    {
        return Y;
    }
}

class TestPoint2Class
{
    static void Main() // complier always starts here.
    {
        Point pt = new Point(10, 20); //1. point called pt. //(10,20) are parameters.
        // could be writen as:
        // point pt; (declariing)
        // pt = new apoint(10,20); (instantiating)
        //3. pt is nothing until line is exacuted.
        

        Console.WriteLine("{0},{1}", pt.GetX(), pt.GetY()); // no direct access, but can get it through GetX & GetY. Called Data HIding.
        //4. 
    }

}