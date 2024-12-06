using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_10._4
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

            var lastDigit = n % 10;
            var amount = 0;
            var temp = n;
            while(temp>0)
            {
                var digit = temp % 10;
                if (digit == lastDigit)
                {
                    amount += 1;
                }
                temp /= 10;
            }
            Console.WriteLine($"Цифра {lastDigit} встречается {amount} раз(а) в числе {n}.");
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
