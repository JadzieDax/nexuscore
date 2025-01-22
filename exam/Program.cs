using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            if (!TryNaturalNumber("Введите натуральное четное число, большее или равное 4:", out n))
            {
                Console.ReadKey();
                return;
            }
            Calculation(n);
            Console.ReadKey();
        }
        static bool TryNaturalNumber(string message, out int number)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();

            if ((!int.TryParse(input, out number)) || (number < 4) || number % 2 != 0)
            {
                Console.WriteLine("Для работы программы нужно ввести четное натуральное число, большее или равное 4");
                return false;
            }
            return true;
        }
        static bool IsPrimeNumber(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= number/2; i++)
            {
                if (number % i == 0) return false;
            }
            return true;

        }
        static void Calculation(int n)
        {
            for (int i = 2; i <= n; i++)
            {
                if (IsPrimeNumber(i) && IsPrimeNumber(n - i))
                {
                    Console.WriteLine($"Разложение заданного числа на простые слагаемые: {n} = {i} + {n - i}");
                    return;
                }
            }
        }
    }
}
