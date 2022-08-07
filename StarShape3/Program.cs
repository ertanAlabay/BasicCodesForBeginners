using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarShape3
{
    internal class Program
    {
        static void ChristmasTree()// or arrow :D
        {
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 20; j += 2)
                {
                    for (var k = 0; k < (20 - j) / 2; k++)
                    {
                        Console.Write(" ");
                    }
                    for (var m = 0; m <= j; m++)
                    {
                        Console.Write("*");
                    }
                    for (var n = (20 - j) / 2; n < 20; n++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                for (int p = 0; p < 5; p++)
                {
                    for (int r = 0; r < 8; r++)
                    {
                        Console.Write(" ");
                    }
                    for (int s = 0; s < 5; s++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            ChristmasTree();
        }
    }
}
