using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

       
        string line = "Oh my love, my darling ";
		int sIndex = 0;
		int eIndex = 0;
		int wLength = 0;
		
		for (int a = 0; a < line.Length; a++)
		{
            while (line.Substring(a, 1) == " ")
            {
	            a++;
            }
        sIndex = a;
        eIndex = a;
			while (line.Substring(a, 1) == " ")
			{
				eIndex++;
            }

        wLength = eIndex - sIndex;
        Console.WriteLine(line.Substring(sIndex, wLength));
        a = eIndex;
        }


























                Console.ReadKey();
        }
    }
}
