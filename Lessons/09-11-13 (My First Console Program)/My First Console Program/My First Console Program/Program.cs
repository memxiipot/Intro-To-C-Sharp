using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My_First_Console_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.Write("Hello dudes\n");
            Console.Write("\t\aWhat is your name? ");

            Console.ReadLine();
        }
    }
}
