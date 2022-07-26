using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!".SubstringAfter(" "));
            //=> return World!

            Console.WriteLine("SOMETHING", "FIND >>> SOMETHING <===< HERE".SubstringBetween(">>> ", " <===<"));
            //=> return SOMETHING

            Console.WriteLine("[ERROR]: Missing ; on line 20.".Message());
            //=> return Missing ; on line 20.

            Console.WriteLine("[WARNING]: Library is deprecated.".LogLevel());
            //=> return WARNING
        }
    }
}
