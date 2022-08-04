using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    internal class Program
    {
        static void LeapYear(int year)
        {
            if( year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine(year + " is a Leap year");
            }
            else
            {
                Console.WriteLine(year + " is not a Leap year");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year to calculate leap year or not.");
            
            Console.Write("Year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            LeapYear(year);
        }
    }
}
