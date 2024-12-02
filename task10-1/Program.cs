using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            if (!TryInputNumber("Введите значение a (максимальное положительное число дюймов): ", out a))
            {
                Console.ReadKey();
                return;
            }

            double h = 0;
            if (!TryInputNumber("Введите значение h (шаг):", out h))
            {
                Console.ReadKey();
                return;
            }
            if (a < 0 || h > a || h <=0)
            {
                Console.WriteLine("Не выполняется условие h < a, h > 0 или a >= 0");
                Console.ReadKey();
                return;
            }


            double inchConverter = 2.54;
            Console.WriteLine("Дюймы \t Сантиметры");
            for (double i = h; i <= a; i += h)
            {
                Console.WriteLine($"{i} \t {i * inchConverter}");
            }
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
    }
}

