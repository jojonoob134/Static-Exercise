using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal class TempConverter
    {
        public static void FahrenheitToCelsius(double Fahrenheit)
        {
            double Celsius = Fahrenheit - 32;
            Celsius = (Celsius * 5) / 9;
            Console.WriteLine($"It is {Celsius} celsius outside");
        }
        public static void CelsiusToFahrenheit(double Celsius)
        {
            double Fahrenheit = (Celsius * 9) / 5;
            Fahrenheit += 32;
            Console.WriteLine($"It is {Fahrenheit} fahrenheit outside");
        }
    }
}
