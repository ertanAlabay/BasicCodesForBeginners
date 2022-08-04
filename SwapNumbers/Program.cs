using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, temp;

            Console.Write("Number 1: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number 2: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            temp = number1;
            number1 = number2;
            number2 = temp;

            Console.WriteLine("New number 1 is " + number1);
            Console.WriteLine("New number 2 is " + number2);

        }
    }
}
