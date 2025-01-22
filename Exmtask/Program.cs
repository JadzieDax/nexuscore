using System;
namespace exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите натуральное четное число, большее или равное 4:");
            var input = Console.ReadLine();

            if ((!int.TryParse(input, out n)) || (n < 4) || n % 2 != 0)
            {
                Console.WriteLine("Для работы программы нужно ввести четное натуральное число, большее или равное 4");
                Console.ReadKey();
                return;
            }

            for (int i = 2; i <= n; i++)
            {
                if (IsPrimeNumber(i) && IsPrimeNumber(n - i))
                {
                    Console.WriteLine($"Разложение числа на простые слагаемые: {n} = {i} + {n - i}");
                    Console.ReadKey();
                    return;
                }
            }
            Console.ReadKey();
        }

        static bool IsPrimeNumber(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}