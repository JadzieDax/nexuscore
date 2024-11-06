using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию белого коня:");
            var whiteKnightPosition = Console.ReadLine();

            if (!IsKnightPositionCorrect(whiteKnightPosition))
            {
                Console.WriteLine("Некорректная позиция для коня");

                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите позицию черного коня:");
            var blackKnightPosition = Console.ReadLine();

            if (!IsKnightPositionCorrect(blackKnightPosition) || whiteKnightPosition == blackKnightPosition)
            {
                Console.WriteLine("Черный конь не должен стоять на этой клетке");

                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите ход белого коня:");
            var move = Console.ReadLine();

            if (IsKnightMoveCorrect(move, whiteKnightPosition, blackKnightPosition))
                Console.WriteLine("Ход разрешен");
            else
                Console.WriteLine("Ход запрещен");

            Console.ReadKey();
        }

        static bool IsKnightPositionCorrect(string position)
        {
            int r, c;

            DecodePosition(position, out c, out r);

            return r >= 1 && r <= 8 && c >= 1 && c <= 8;
        }

        static bool IsKnightMoveCorrect(string move, string knightPosition, string blackKnightPosition)
        {
            int kc, kr, mc, mr, oc, or;

            DecodePosition(knightPosition, out kc, out kr);
            DecodePosition(move, out mc, out mr);
            DecodePosition(blackKnightPosition, out oc, out or);

            int[] dx = { -2, -1, 1, 2, 2, 1, -1, -2 };
            int[] dy = { 1, 2, 2, 1, -1, -2, -2, -1 };

            for (int i = 0; i < 8; i++)
            {
                if (mc == kc + dx[i] && mr == kr + dy[i] && move != blackKnightPosition)
                {
                    return true;
                }
            }

            return false;
        }

        static void DecodePosition(string position, out int column, out int row)
        {
            row = int.Parse(position[1].ToString());
            column = (int)position[0] - 0x60;
        }
    }
}
