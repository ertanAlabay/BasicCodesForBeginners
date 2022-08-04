using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumbersWithFunction
{
    internal class Program
    {
        public static void SwapNumbers(int a, int b)
        {
            int temp;

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("New number 1 is " + a);
            Console.WriteLine("New number 2 is " + b);

        }
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Please enter two numbers.");

            Console.Write("Number 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            SwapNumbers(num1, num2);

        }
    }
}
