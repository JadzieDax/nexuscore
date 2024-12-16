using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число m от 5 до 20");
            int m;

            if (!TryInputNumber(out m))
            {
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите целое число n от 5 до 20");
            int n;

            if (!TryInputNumber(out n))
            {
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Введите цифру k для проверки");
            int k;
            if (!TryInputNumber(out k))
            {
                Console.ReadKey();
                return;
            }

            if (k < 0 || k > 9)
            {
                Console.WriteLine("Числа не удовлетворяют неравенству 0 < k < 9");
                Console.ReadKey();
                return;
            }

            if (m < 5 || m > 20 || n < 5 || n > 20)
            {
                Console.WriteLine("Числа не удовлетворяют неравенству 5 <= m,n <= 20");
                Console.ReadKey();
                return;
            }

            Console.WriteLine();

            var matrix = new int[m, n];

            var rnd = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = rnd.Next(100);

            PrintMatrix(matrix);
            Console.WriteLine();

            Console.WriteLine("Индексы элементов, последняя цифра которых совпадает с k");
            GetLastDigit(matrix, k);
            Console.WriteLine();

            var indexes = GetIndexOfLineWithMinimalLastElement(matrix);
            for (int i = 0; i < indexes.Length; i++)
                Console.WriteLine($"Мин. значение в строке {i+1}: {indexes[i]}");

            Console.ReadKey();
        }

        static bool TryInputNumber(out int number)
        {
            number = 0;
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }

            number = n;
            return true;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write($"{matrix[i, j],2} ");

                Console.WriteLine();
            }
        }
        static void GetLastDigit(int[,] matrix, int k)
        {
            bool found = false;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    if (matrix[i, j] % 10 == k)
                    {
                        Console.Write($"({i + 1}, {j + 1}) ");
                        found = true;
                    }

                }
            }
            if (found == false)
            {
                Console.WriteLine("Совпадений не найдено");
            }

        }
        static int[] GetIndexOfLineWithMinimalLastElement(int[,] matrix)
        {
            var result = new int[matrix.GetLength(0)];

            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                var min = int.MaxValue;


                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < min)
                        min = matrix[i, j];

                }

                result[i] = min;
            }


            return result;
        }
    }
}