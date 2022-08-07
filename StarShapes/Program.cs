using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarShapes
{
    internal class Program
    {
        static void Parallelogram()
        {
            for (int i = 0; i<5; i++)
            {
                for (int k=5-i; k > 0; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 15; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Parallelogram();
        }
    }
}
