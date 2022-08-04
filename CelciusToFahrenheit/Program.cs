using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelciusToFahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Enter a number : ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            if (celsius <= -273.15)
            {
                Console.WriteLine("Temperature below absolute zero!");
            }
            else
            {
                double fahrenheit = celsius * 1.8 + 32;
                Console.WriteLine(celsius + " Celcius equals " +fahrenheit + " Fahrenheit.");
            }
        }   
    }
    
}
