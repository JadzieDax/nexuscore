using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            double b = 0;
            if (!TryInputNumber("Укажите 1й элемент прогрессии b ", out b))
            {
                Console.ReadKey();
                return;
            }

            double q = 0;
            if (!TryInputNumber("Укажите знаменатель прогрессии q", out q))
            {
                Console.ReadKey();
                return;
            }

            double k = 0;
            if (!TryInputNumber("Укажите множитель k для четвертого масива: ", out k))
            {
                Console.ReadKey();
                return;
            }

            var numbers = new double[20];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = b * Math.Pow(q, i);

            }

            Console.WriteLine("20 элементов прогрессии: ");
            DisplayMassive(numbers);

            Console.WriteLine("Члены массива в квадрате: ");
            Pow2Massive(numbers);

            Console.WriteLine("Среднее геометричсекое: ");
            SrednGeometricMassive(numbers);

            Console.WriteLine("Преобразования с помощью множителя k: ");
            DisplayMassive(ProductKArray(numbers, k));

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
        static void DisplayMassive(double[] massive)
        {
            foreach (var element in massive)
                Console.Write($"{element}, ");

            Console.WriteLine("\b\b ");
        }

        static void Pow2Massive(double[] massive)
        {
            if (massive == null || massive.Length == 0)
                return;

            for (int i = 0; i < massive.Length; i++)
            {
                massive[i] = Math.Pow(massive[i], 2);
            }

            foreach (var element in massive)
                Console.Write($"{element}, ");

            Console.WriteLine("\b\b ");
        }

        static void SrednGeometricMassive(double[] massive)
        {
            if (massive == null || massive.Length == 0)
                return;

            double x = 1;
            for (int i = 0; i < massive.Length; i++)
            {
                x *= massive[i];
            }

            Console.WriteLine(Math.Sqrt(x));
        }

        static double[] ProductKArray(double[] massive, double k)
        {
            if (massive.Length == 0)
                return new double[0];

            double[] numbers2 = new double[massive.Length];

            for (int i = 0; i < massive.Length; i++)
            {
                numbers2[i] = massive[i] * k;
            }

            return numbers2;

        }
    }
}