using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            /////////////first sample
            int ctr = 0;
            //while (ctr < 10)
            //{
            //    Console.Write("*\n");
            //    ctr += 2;
            //}

            /////////////ASCII
            //for (ctr = 0; ctr < 256; ctr++)
            //{
            //    Char c;
            //    c = (Char)ctr;
            //    Console.Write(c + "\n");
            //}

            //String s;
            //s = Console.ReadLine();
            //if (s == "I love java")
            //{
            //  int s[] = {};
            //}

            //ppt example asterisk
            int j = 0;
            while (j < 5)
            {
                int i = 0;
                while (i < 10)
                {
                    Console.Write("*");
                    i++;
                }
                Console.Write("\n");
                j++;
            }


            //Hello 10x
            ctr = 0;
            while (ctr < 10)
            {
                Console.Write("Hello");
                ctr++;
            }

            Console.Write("\n\n");

            //0-10 & 10-20
            ctr = 0;
            int num = 10;
            while (ctr <= 10 && num <= 20)
            {
                Console.Write("{0} {1} ", ctr, num); //substitution symbol {0}
                ctr++;
                num++;
            }

            Console.Write("\n\n");

            //0-10 alternative
            for (ctr = 0; ctr <= 10; ctr++)
            {
                Console.Write(ctr + " ");
            }

            Console.Write("\n\n");

            //end number from user
            Console.Write("Input final number: ");
            int x = int.Parse(Console.ReadLine());
            int c = 1;

            while (c <= x)
            {
                Console.WriteLine("{0}", c);
                c++;
            }

            //multiplication table
            int d = 1;
            while (d <= 12)
            {
                Console.Write("{0} x {1} = {2}\n", 5, d, 5 * d);
                d++;
            }

            

            //infinite loop
            while (true)
            {
            }




                Console.ReadKey(true);

        }
    }
}
