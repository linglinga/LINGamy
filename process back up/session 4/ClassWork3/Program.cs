using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// write a program that accepts the hours worked and the hourly wage

namespace ClassWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            // enter the hours worked and store the info
            Console.Write("Please enter the number of hours worked: ");
            string strHours = Console.ReadLine();       // str the string entry of hours entered named strHours.
            double dblHours = double.Parse(strHours);   // convert strHours to double. with only 2 decimals.

            // enter the wage and store the info
            Console.Write("Please enter your hourly wage ($/hour): ");
            string strWage = Console.ReadLine();        // str the string strWage of  the hourly wage entered.
            double dblWage = double.Parse(strWage);     // convert strWage to double. with only 2 decimals.

            // set some variables to store upcoming calcualtions.
            double dblOvertimePay;      // must declare the variable before initiate.
            double dblRegularPay;
            double dblTotalPay;

            if (dblHours > 40) // if did overtime, any hours above 40.
            {
                // calculate overtime working hours and time that by 1.5 the wage
                dblOvertimePay = (dblHours - 40) * (1.5 * dblWage);

                // calculate the regular working hours
                dblRegularPay = (40) * (dblWage);

                // sun up the total hours
                dblTotalPay = dblOvertimePay + dblRegularPay;

                // show what is your regular pay amount
                Console.WriteLine("Your regular pay is ${0}", dblRegularPay);

                // show what is your overtime pay amount
                Console.WriteLine("Your overtime pay is ${0}", dblOvertimePay);

            }
           else // if did not do overtime
            {
                dblRegularPay = (dblHours) * (dblWage);
                dblTotalPay = dblRegularPay;
            }
            Console.WriteLine("Your total pay for this week is ${0}", dblTotalPay);

            Console.ReadLine();
        }
    }
}
