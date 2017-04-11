using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace If___Else_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////////////////////////////

            ////if statements
            //string password;
            //Console.Write ("Input Password: ");
            //password = Console.ReadLine();
            //if (password == "marie") 
            ////{
            //    Console.Write("Access Granted!");
            ////}
            //Console.Write("\n\nDemo Program");
            
            /////////////////////////////////////////////////////////////////

            ////if - else statements
            //Console.Write("\n\nInput Grade: ");
            //int grade = int.Parse (Console.ReadLine());
            //if (grade >= 70)
            ////{
            //    Console.Write("You Passed!");
            ////} 
            //else
            ////{
            //    Console.Write("You Failed!");
            ////}

            /////////////////////////////////////////////////////////////////

            ////if - else if statement
            //Console.Write ("\n\nInput Age: ");
            //int age = int.Parse (Console.ReadLine());

            //if (age >= 0 && age <=20 )
            //{
            //    Console.Write("You're still young.");
            //}
            //else if (age >=21 && age <= 50)
            //{
            //    Console.Write("You're an adult.");
            //}
            //else if (age >= 51 && age <= 90)
            //{
            //    Console.Write("You're old.");
            //}
            //else
            //{
            //    Console.Write("You're.... still alive?");
            //}

            /////////////////////////////////////////////////////////////////

            ////switch stament (string)
            //Console.Write("\n\nInput A, B or C: ");
            //string choice = Console.ReadLine();
            //switch (choice)
            //{
            //    case "A":
            //        Console.Write("You selected A.");
            //        break;
            //    case "B":
            //        Console.Write("You selected B.");
            //        break;
            //    case "C":
            //        Console.Write("You selected C.");
            //        break;
            //    default:
            //        Console.Write("Invalid Input!");
            //        break;
            //}

            ////switch stament (number)
            //Console.Write("\n\nInput 1, 2 or 3: ");
            //int choice2 = int.Parse (Console.ReadLine());
            //switch (choice2)
            //{
            //    case 1:
            //        Console.Write("One!");
            //        break;
            //    case 2:
            //        Console.Write("Two!!");
            //        break;
            //    case 3:
            //        Console.Write("Three!!!");
            //        break;
            //    default:
            //        Console.Write("Invalid Input!!!!");
            //        break;
            //}

            ///////////////////////////////////////////////////////////////

            //
            Start: 
            Console.Write("Input Command: ");
            string cmd = Console.ReadLine();
            if (cmd == "yellow")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (cmd == "exit")
            {
                return;
            }
            else if (cmd == "what's your name?")
            {
                Console.Write("i am your program!\n");
                Console.Write("i have no name!\n");
            }
            else if (cmd == "facebook")
            {
                System.Diagnostics.Process.Start(
                    "iexplore", "www.facebook.com");
            }
            else if (cmd == "excel")
            {
                System.Diagnostics.Process.Start(
                    "excel.exe");
            }
            goto Start;

            //Console.ReadKey(true);


        }     
    }
}
