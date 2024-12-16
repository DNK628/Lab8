using System;
using System.Text;

namespace FunctionCalculation
{
    class Program
    {
        // 1. Просте використання делегатів 
        static double CalculatePositive(double x)
        {
            return Math.Sin(2 * x);
        }

        static double CalculateNonPositive(double x)
        {
            return 1 + 2 * Math.Sin(2 * x);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть значення x:");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Потрібно було ввести число.");
                return;
            }

            if (double.TryParse(input, out double x))
            {
                Func<double, double> calculateFunction;

                if (x > 0)
                {
                    calculateFunction = CalculatePositive;
                }
                else
                {
                    calculateFunction = CalculateNonPositive;
                }

                double result = calculateFunction(x);
                Console.WriteLine($"F({x}) = {result}");
            }
            else
            {
                Console.WriteLine("Потрібно було ввести число.");
            }
        }
    }
}
