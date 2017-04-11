using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Letter_B
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;  // # of spaces
            int y = 0;  // # of \n's

            while (true)
            {
                Console.Clear();
                int a = 1;      //newline y times
                while (a <= y)
                {
                    Console.Write("\n"); a++;
                }
                int b = 1;      //print space x times
                while (b <= x)
                {
                    Console.Write(" "); b++;
                }
                Console.Write("B");

                ConsoleKeyInfo k = Console.ReadKey();
                if (k.Key == ConsoleKey.RightArrow)
                    x++;
                else if (k.Key == ConsoleKey.LeftArrow)
                    x--;
                else if (k.Key == ConsoleKey.DownArrow)
                    y++;
                else if (k.Key == ConsoleKey.UpArrow)
                    y--;
                else if (k.Key == ConsoleKey.Escape)
                    break;
            }
        }
    }
}
