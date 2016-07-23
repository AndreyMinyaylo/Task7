using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Treatment
    {
        public string result(string someString)
        {
            ConsoleKeyInfo cki;
            Console.WriteLine(someString);
            cki = Console.ReadKey();
            if ((cki.Modifiers & ConsoleModifiers.Control)
        }
    }
    class Call
    {
        public static string input(string consoleMsg = "Enter somthing")
        {
            Console.WriteLine(consoleMsg);
            var someInput = Console.ReadLine();
            return someInput;
        }

        public static void result()
        {
            var someStrings = input();

        }

        static void Main(string[] args)
        {
            result();
        }
    }
}
