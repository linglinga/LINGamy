using System; // always use this.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork_1
{
    // Exercise: find the ascii value of a given character.
    // every key on the keyboard is associated with a number.
    class Program // automatic
    {
        static void Main(string[] args) // this is where it starts.
        {

            //ask the user to enter a character (in front of my request)
            Console.Write("Enter a character:");

            //read and store the input from the user (from the console)
            string str = Console.ReadLine(); // I grab and store information as a string
            // string is a C# string.
            // String is a class string.



            //make sure you grab the first character that they entered 
            //(regardless of what they had entered)
            char c = str[0]; // could be: char mychar = str[0]; 

            
            //grab or covert the character into a number (ascii number)
            // i am going from char 2 bytes to interger 4 bytes (implicit)
            int myascii = (int)c; // or c could be myChar.
            // myascii could be myint... it is something you name. but name it logically and easy to understand.

            //show the integer or the result on the console (on my black screen)
            Console.WriteLine("Ascii = {0} = {1}", c, myascii); // {0} is c, {1} is myascii. placeholder.

            Console.ReadLine(); // to hold the console so you can see the result
        }
    }
}
