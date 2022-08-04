using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberCheck
{
    //Write a method that checks if given number (positive integer) contains digit 3.
    //Do not convert number to other type.
    internal class Program
    {

        static bool NumberCheck(int number)
        {
            while (0 < number)
            {
                if (number % 10 == 3)
                {
                    return true;
                }
                
                number /= 10;
                
            }
            return false;
        } 
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int a = Convert.ToInt32(Console.ReadLine());
            
            if (a <= 0)
            {
                Console.WriteLine("Enter a positive number.");
            }
            else
            {
                Console.WriteLine(NumberCheck(a));
            }
            
        }
    }
}
