using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PozitiveOrNegative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number;

            Console.WriteLine("Enter a number to check positif or negative.");
            Console.Write("Number : ");
            number = Convert.ToDouble(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("Number is negative.");
            }
            else if(number == 0)
            {
                Console.WriteLine("Number equals 0.");
            }
            else
            {
                Console.WriteLine("Number is positive.");
            }
        }
    }
}
