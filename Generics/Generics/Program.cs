using System;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            double[] percent = { 1.2, 2.3, 22.6, 50.7, 0.85 };
            Char[] Alphabets = { 'R', 'E', 'S', 'D' };

            Program.toPrint(numbers);
            Program.toPrint(percent);
            Program.toPrint(Alphabets);
        }
        public static void toPrint(int[] numbers)
        {
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("----------------------");
        }
        public static void toPrint(double[] percent)
        {
            foreach (double per in percent)
            {
                Console.WriteLine(per);
            }
            Console.WriteLine("----------------------");
        }
        public static void toPrint(char[] Alphabets)
        {
            foreach (char letter in Alphabets)
            {
                Console.WriteLine(letter);
            }
            Console.WriteLine("----------------------");
        }
    }
}