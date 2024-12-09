using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double b = 0;
            if (!TryInputNumber("Введите первый член прогрессии ", out b))
            {
                Console.ReadKey();
                return;
            }

            double q = 0;
            if (!TryInputNumber("Введите знаменатель прогрессии", out q))
            {
                Console.ReadKey();
                return;
            }

            double k = 0;
            if (!TryInputNumber("Введите значение множителя k для четвертого масива: ", out k))
            {
                Console.ReadKey();
                return;
            }

            var numbers = new double[20];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = b * Math.Pow(q, i);

            }

            Console.WriteLine("Геометрическая прогрессия из 20 элементов: ");
            PrintArray(numbers);

            Console.WriteLine("Каждый элемент геометрической прогрессии в квадрате: ");
            SquareArray(numbers);

            Console.WriteLine("Среднее геометрическое массива: ");
            GeometricMeanArray(numbers);

            Console.WriteLine("Массив, умноженный на k: ");
            PrintArray(ProductKArray(numbers, k));

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
        static void PrintArray(double[] array)
        {
            foreach (var element in array)
                Console.Write($"{element}, ");

            Console.WriteLine("\b\b ");
        }

        static void SquareArray(double[] array)
        {
            if (array == null || array.Length == 0)
                return;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Math.Pow(array[i], 2);
            }

            foreach (var element in array)
                Console.Write($"{element}, ");

            Console.WriteLine("\b\b ");
        }

        static void GeometricMeanArray(double[] array)
        {
            if (array == null || array.Length == 0)
                return;

            double product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }

            Console.WriteLine(Math.Sqrt(product));
        }

        static double[] ProductKArray(double[] array, double k)
        {
            if (array.Length == 0)
                return new double[0];

            double[] numbers2 = new double[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                numbers2[i] = array[i] * k;
            }

            return numbers2;

        }
    }
}