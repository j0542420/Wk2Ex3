using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk2Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarations
            double F = '0';

            //title of the converter app
            Console.WriteLine("Welcome to Temperature Converter");

            //input the temperature in F
            Console.WriteLine("Enter the temperature: ");
            //collect the user input of the temperature
            F = Convert.ToInt32(Console.ReadLine());

            //calculate the temperature from F to C
            double C = (F-32)*5/9;
            // round up to two decimals
            C = Math.Round(C, 2);

            //output the result
            Console.WriteLine($"{F}°F is equivalent to {C}°C");

        }
    }
}
