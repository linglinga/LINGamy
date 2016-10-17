using System;

namespace HomeWork3 // HomeWork 3: Control Statements
                    // take seconds and converts it into days, hours, minutes, seconds per minute.
{
    class Program
    {
        static void Main()
        {
            // 1. ask user to input the seconds to be converted for the console.
            Console.Write("Please input how many seconds: ");
            

            // 2. read the number from console, and store it into a string type.
            string str; // declar the string. store the string
            str = Console.ReadLine();   // read it and store it.

            // 3. convert the number that is in the string format to the numeric format.
            int x = int.Parse(str);
            int seconds = x;

            // 4. convert number to days, hours, minutes & seconds.
            // variable that has the number seconds per day, the number seconds per hour, and the number seconds per minute.

            TimeSpan t = TimeSpan.FromSeconds(seconds);

            int d = t.Days;
            int hr = t.Hours;
            int mn = t.Minutes;
            int ss = t.Seconds;

            Console.WriteLine("Days:" + d + " HR:" + hr + " M:" + mn + " S:" + ss);

            Console.ReadLine(); // to hold up the console, always leave this in here.

        }
    }
}