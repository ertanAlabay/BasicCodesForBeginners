using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusToFahrenheitWithFunction
{
    internal class Program
    {
        static string CelToFah(double celsius)
        {
            double fahrenheit;

            if (celsius < -273.15)
            {
                return "\nTemperature below absolute zero!\n";
            }

            fahrenheit = celsius * 1.8 + 32;

            return "\n" + celsius + " Celsius equals " + $" {fahrenheit} Fahrenheit";
        }
    
        static void Main(string[] args)
        {
            
            Console.Write("\nEnter a celsius to convert fahrenheit: ");

            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(CelToFah(a));
        }
    }
}
