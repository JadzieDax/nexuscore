using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_10._2
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

            double a; 
            double sum = 0;
            for (var i = 1; i <= n; i++)
            {
                Console.WriteLine($"Шаг {i}. ");
                if (!TryInputNumber("Введите действительное число a:", out a))
                {
                    Console.ReadKey();
                    return;
                }
                if (i % 4 == 1 || i % 4 == 2)
                {
                    sum += a;
                }
                else
                {
                    sum -= a;
                }

            }
            Console.WriteLine($"Результат: {sum}");
            Console.ReadKey();
        }

        static bool TryInputNumber(string message, out double number)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();

            if (!double.TryParse(input, out number))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }

            return true;
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
