// File: if_ex1.cs
// Ask user to input a month number 1, or 2, or 3 for (jan, feb, and Mar).
// Then check how many days each month has (say 31, 29, 30 days for each).
// Print the month and the number of days to screen.
// Finish the rest of exercise on your own and include all the months of the year.

using System;

class ex1
{
    static void Main()
    {
        string strName;
        while (true) // looping. as long as its true, keep going. A type of infinite loop.
        {
            // have user input the month number from 1-12.
            Console.Write("Please enter a month number (1 to 12): ");
            strName = Console.ReadLine(); // str the number entered as strName.

            string month;                   // name of the string is month.
            int nDays = 0;                  // declare a variable named nDays. // Assign it a value of 0.

            switch (strName)                // exclusive statement of the strName.
            { // how to find the end bracket: (highlight this bracket > control + } )
                case "1":                   // can put { } after case "1" and encase {month - ... break;}
                    month = "January";
                    nDays = 31;
                    break;

                case "2":
                    month = "February";
                    nDays = 29;
                    break;
                case "3":
                    month = "March";
                    nDays = 31;
                    break;
                case "4":
                    month = "April";
                    nDays = 30;
                    break;
                case "5":
                    month = "May";
                    nDays = 31;
                    break;
                case "6":
                    month = "June";
                    nDays = 30;
                    break;
                case "7":
                    month = "July";
                    nDays = 31;
                    break;
                case "8":
                    month = "August";
                    nDays = 31;
                    break;
                case "9":
                    month = "September";
                    nDays = 30;
                    break;
                case "10":
                    month = "October";
                    nDays = 31;
                    break;
                case "11":
                    month = "November";
                    nDays = 30;
                    break;
                case "12":
                    month = "December";
                    nDays = 31;
                    break;

                // Continue the code up to case "12", December
                default:                // is none of the cases above applies. // default will run.
                    month = "unknown";
                    nDays = -1;
                    break;
            } // end of switch

            Console.WriteLine("The month {0} has {1} days", month, nDays);
            Console.ReadLine();
        } // end of while loop.
    } // end of main

} // end of class