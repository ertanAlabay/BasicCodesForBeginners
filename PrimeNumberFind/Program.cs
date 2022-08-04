using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberFind
{
    internal class Program
    {
        static void FindPrime(int number)
        {
            for (int i = 0; i <= number; i++)
            {
                //ctr = 0;

                for (int j = 2; j <= i ; j++)
                {
                    if ((i % j) == 0)
                    {
                        //ctr++;
                        break;
                    }
                    //Console.Write("{0} ", i);
                }
                //if (ctr == 0 && num != 1)
         
            }
            Console.Write("\n");
        }
    

        static void Main(string[] args)
        {
        
            Console.WriteLine("Enter a number to calculate prime numbers of given number.");
            Console.Write("Number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            FindPrime(a);
        }
    }
}
