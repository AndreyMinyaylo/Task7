using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;



namespace Test
{
    class PushKey
    {
        public  PushKey()
        {
        
        ConsoleKeyInfo cki;
        Console.TreatControlCAsInput = true;
           Console.WriteLine("Press any combination of CTL, ALT, and SHIFT, and a console key.");
            Console.WriteLine("Press the Escape (Esc) key to quit: \n");
            do
            {
                    cki = Console.ReadKey(true);
                   
                if ((cki.Modifiers & ConsoleModifiers.Control) != 0 & cki.Key == ConsoleKey.Z)
                {
                    Console.WriteLine("Congratulation! You Enter Ctrl and z");

                }

            } while (cki.Key != ConsoleKey.Escape);
        }
    }

    class Action
    {
        
    }
    class Program
    {
        public static string input(string consoleMsg = "Enter numder")
        {
            Console.WriteLine(consoleMsg);
            var tmp = Console.ReadLine();
            return tmp;
        }
        public static void consoleOut()
        {
            //Action ActionObject = new Action();
            var consoleEnter = input("Enter something");

        }
        
        public static void Main()
        {
           
        }

    }
    }

