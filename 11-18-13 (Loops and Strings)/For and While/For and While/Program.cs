using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace For_and_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            while (a < 10)
            {
                //Some Codes
                a++;
            }

            a = 0;
            while (a < 10)
            {
                //Some Codes
                a++;
            }

            for (int i = 0; i < 10; i++)
            {
                //Some Codes
            }
            for (int i = 0; i < 10; i++)
            {
                //Some Codes
            }

            int x = 0;
            for (; x < 10; )
            {

                x++;
            }

            for (; ; )
            {
                Console.Write("Input Command:");
                string str = Console.ReadLine();
                if (str == "red")
                {
                    Console.ForegroundColor =
                        ConsoleColor.Red;
                }
                else if (str == "skip")
                {
                    continue;
                }
                else if (str == "exit")
                {
                    break;
                }

                for (int i = 0; i < 1000000000; i++)
                {   //nothing
                }
            }


        }
    }
}
