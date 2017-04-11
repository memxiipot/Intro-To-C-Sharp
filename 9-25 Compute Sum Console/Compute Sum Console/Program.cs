using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compute_Sum_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Compute Sum v1.0");
            Console.Write("\n\n");
            Console.Write("Input 1st number to compute: ");
            int num1;
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Input 2nd number to compute: ");
            int num2;
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Input 3rd number to compute: ");
            int num3;
            num3 = int.Parse(Console.ReadLine());
            int numSum;
            numSum = num1+num2+num3;

            //*Version 1
            //Console.Write(numSum)
            
            //Version 2
            // Console.Write("{0} + {1} + {2} + {3}.\n", 
            //    num1, num2, num3, numSum);
            //Console.Write("The Sum is {0}.", numSum);
            
            //Version 3 (String addition-concatenation)
            //Console.Write(num1 + "+" + num2 + "+" + num3 + "=" + numSum + ".\n");
            //Console.Write("The Sum is " + numSum);
            
            //Version 4 (Combination)
            //Console.Write("{0} + {1} + {2} + {3}.\n",
            //    num1, num2, num3, numSum);
            //Console.Write("The Sum is " + numSum);

            //Console.ReadLine(); - allow the user to encode a set of strings
            //Console.ReadKey(); - read one key stroke
            //Console.ReadKey(true); - not going to see the input
            //Console.ReadKey(false); - defult

            Console.Write("{0} + {1} + {2} + {3}.\n", 
                num1, num2, num3, numSum);
            Console.Write("The Sum is {0}.", numSum);
            Console.ReadLine();
        }
    }
}
