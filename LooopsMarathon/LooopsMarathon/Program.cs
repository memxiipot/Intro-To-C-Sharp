using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LooopsMarathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            for (; ; )
            {
                if (x >= 200)
                {
                    break;
                    
                }
                x++;
                Console.WriteLine("---------------");
            }
            
            Console.ReadKey();

        }
    }
}
