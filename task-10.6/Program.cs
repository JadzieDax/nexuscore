using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_10._6
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
            for (int i = 1; i < n; i++)
            {
                int sum = SumDivisors(i);
                if (sum > i && sum < n)
                {
                    if (SumDivisors(sum) == i)
                    {
                        Console.WriteLine($"Пара дружественных чисел: {i} и {sum}");
                    }
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
        static int SumDivisors (int number) 
        {
            int sum = 0;
            for (int i = 1; i <= number/2; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
