using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            if (!TryNaturalNumber("Введите натуральное число n:", out n))
            {
                Console.ReadKey();
                return;
            }
            Console.WriteLine($"Натуральные числа, квадрат которых меньше n:");
            for (var i = 1; i < n; i++)
            {
                if (Math.Pow(i, 2) < n)
                {
                    Console.Write($"{i} ");
                }

            }
            Console.ReadKey();
        }

        static bool TryNaturalNumber(string message, out int number)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();

            if ((!int.TryParse(input, out number)) || (number < 0) || (number % 1 != 0))
            {
                Console.WriteLine("n должно быть натуральным");
                return false;
            }
            return true;
        }
    }
}
