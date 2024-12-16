using System;
using System.Text;

namespace SeasonTemperature
{
    class Program
    {
        static string GetSeason(int month)
        {
            return month switch
            {
                12 or 1 or 2 => "Зима",
                3 or 4 or 5 => "Весна",
                6 or 7 or 8 => "Літо",
                9 or 10 or 11 => "Осінь",
                _ => "Невірний номер місяця"
            };
        }

        static double WinterTemperature() => -5.0;

        static double SpringTemperature() => 10.0;

        static double SummerTemperature() => 25.0;

        static double AutumnTemperature() => 10.0;

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Func<int, double> getAverageTemperature = month =>
            {
                return month switch
                {
                    12 or 1 or 2 => WinterTemperature(),
                    3 or 4 or 5 => SpringTemperature(),
                    6 or 7 or 8 => SummerTemperature(),
                    9 or 10 or 11 => AutumnTemperature(),
                    _ => double.NaN
                };
            };

            Console.WriteLine("Введіть номер місяця (1-12):");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int month) && month >= 1 && month <= 12)
            {
                string season = GetSeason(month);
                double averageTemperature = getAverageTemperature(month);

                Console.WriteLine($"Пора року: {season}");
                Console.WriteLine($"Середня температура: {averageTemperature}°C");
            }
            else
            {
                Console.WriteLine("Невірне число. Введіть число від 1 до 12.");
            }
        }
    }
}

