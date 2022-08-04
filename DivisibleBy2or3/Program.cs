using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleBy2or3
{
    internal class Program
    {
        //Given two integers, write a method that returns their multiplication
        //if they are both divisible by 2 and 3, otherwise returns thier sum.
        static int Divisible2or3(int a, int b)
        {
            if ( (a % 2) == 0 && (a % 3) == 0 && (b % 2)== 0 && (b % 3) == 0)
            {
                return a * b;
            }
            else
            {
                return a + b;
            }
        }
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter two number!");

            Console.Write("Number 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Divisible2or3(num1, num2));
        }
    }
}
