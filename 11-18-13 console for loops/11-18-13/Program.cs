using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11_18_13
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //for loops
            for (int ctr = 0; ctr < 10; ctr++)
            {
                Console.Write("*");
                //break;
            }
            

            //nested for loop
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("*");
                    //continue;
                }
                Console.Write("\n");
            }


            for (;;)
            {
                Console.Write("Input Command: ");
                string str = Console.ReadLine();
                if (str == "red")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                    else if (str == "skip")
                    {
                        continue;
                    }
                    else if (str == "exit")
                    {
                        break;
                    }

                for (int i = 0; i < 100000000; i++)
                {
                    //delay/waiting time
                }
            }


            int favoriteNum = 7;
            Console.Write("My favorite number is " + favoriteNum.ToString());

            String a = "\nHello! How are you today?";
            Console.Write(a.ToUpper());
            Console.WriteLine(a.ToLower());
            Console.WriteLine(a.Length.ToString());

            a = "            Remove white space in front";
            Console.WriteLine(a.TrimStart());

            a = "Remove white space in the back            ";
            Console.WriteLine(a.TrimEnd());

            a = "            Remove white space in front and back            ";
            Console.WriteLine(a.Trim());

            a = "Hello! How are you today?";
            //7th character. 3 characters after that
            //How?
            Console.Write(a.Substring(7, 3));
            Console.Write(a.Substring(24, 1));

            a = "ABCDEFG";
            Console.Write("\n" + a[0]);
            Console.Write(a[6]);


            Console.ReadKey(true);
        }
    }
}
