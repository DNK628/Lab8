using System;
using System.Text;

namespace ArithmeticCalculator
{
    class Program
    {
        static double Add(double a, double b) => a + b;

        static double Subtract(double a, double b) => a - b;

        static double Multiply(double a, double b) => a * b;

        static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Ділення на нуль неможливе.");
                return double.NaN;
            }
            return a / b;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Func<double, double, double> operation = null;

            Console.WriteLine("Арифметичний калькулятор");
            Console.WriteLine("Введіть перше число:");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Некоректне значення!");
                return;
            }

            Console.WriteLine("Введіть друге число:");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Некоректне значення!");
                return;
            }

            Console.WriteLine("Оберіть операцію (+, -, *, /):");
            string operationInput = Console.ReadLine();

            switch (operationInput)
            {
                case "+":
                    operation = Add;
                    break;
                case "-":
                    operation = Subtract;
                    break;
                case "*":
                    operation = Multiply;
                    break;
                case "/":
                    operation = Divide;
                    break;
                default:
                    Console.WriteLine("Некоректна операція!");
                    return;
            }

            double result = operation(num1, num2);

            Console.WriteLine($"Результат: {num1} {operationInput} {num2} = {result}");
        }
    }
}
