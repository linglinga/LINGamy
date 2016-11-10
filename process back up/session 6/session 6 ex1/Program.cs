using System;

class session6ex1
{
    static void Main()
    {
        int[] numbers = new int[] { 10, 15, 20, 25, 30, 35 }; // array called numbers, but it could be anything, a name or object.
        // program to have it check if it match 10, if not, then 15, etc.

        Console.Write("Enter a number:");
        string str = Console.ReadLine();

        int num = int.Parse(str);  // convert input string into a number
        bool found = false;          // set a boolean flag // ususally more straight fwd to se to false and find if its true. 

        foreach (int x in numbers) // code here // use foreach to look for the number
            // foreach int x in "myarray"
            // checking int with num
            if (num == x) // could be (x == num)
            {
               found = true; // if number is found set found flag to true
            }

        // out of the entire if, else, only 1 outcome, not both.
        if (found) //  means if true, i.e. found the number, say Found the Number
        {
            Console.WriteLine("Found the number");
        }
        else // if not true, did not find it, say Did not Find the Number
        {
            Console.WriteLine("Did not Find the Number");
        }

        Console.ReadLine();
    }
}