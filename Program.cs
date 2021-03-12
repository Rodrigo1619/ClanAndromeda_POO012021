using System;

namespace ActIntroGithub
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            Console.WriteLine("Type a value for a: ");
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Type a value for b: ");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Subtracting {a} - {b} equals {SubtractNumbers(a, b)}");
        }
        public static int SubtractNumbers(int a, int b)
        {
            return a - b;
        }
    }
}
