using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_10._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n;
            if (!TryInputNumber("Введите n - расстояние, которое пробежал лыжник в первый день: ", out n))
            {
                Console.ReadKey();
                return;
            }
            double m;
            if (!TryInputNumber("Введите m - число процентов, на которое лыжник увеличивал пробег", out m))
            {
                Console.ReadKey();
                return;
            }
            double k;
            if (!TryInputNumber("Введите k", out k))
            {
                Console.ReadKey();
                return;
            }
            if ((m < 0) || (n <= 0) || (k <= 0))
            {
                Console.WriteLine("Для задачи должны выполняться условия m > 0, k >= 0 n >= 0");
                Console.ReadKey();
                return;
            }
            else
            {
                var day = 1;
                for (var i = 1; n < k; i++)
                {
                    n += n * (1 + m / 100);
                    day += 1;
                }
                Console.WriteLine($"Лыжник пробежит больше k километров на {day} день");
                Console.ReadKey();
            }
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
    }
}
