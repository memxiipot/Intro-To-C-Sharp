using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace While_Loop_DEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display Hello 100 times
            int a = 0;
            while (a < 100)
            {
                Console.Write("Hello ");
                a++;
            }
            //Display numbers 1 through 100
            int b = 1;
            while (b <= 100)
            {
                //Console.Write(b);
                Console.Write("{0} ", b);
                b++;
            }
            //Display numbers 1 through x
            Console.Write("Input final number:");
            int x = int.Parse(Console.ReadLine());

            int c = 1;
            while (c <= x)
            {
                Console.WriteLine("{0}", c);
                c++;
            }

            int d = 1;
            while (d <= 12)
            {
                Console.Write("{0} X {1} = {2}\n",
                                5, d, 5 * d);
                d++;
            }


            Console.ReadKey();
        }
    }
}
