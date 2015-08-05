using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonachiIterator
{
    class Runner
    {
        public static int size;
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("\nPlease, enter a size");
                try
                {
                    size = int.Parse(Console.ReadLine());
                    if (size > 0)
                    {
                        foreach (int f in Fibonacci.FibonacciSequence(size))
                        {
                            Console.Write(f + "\t");
                        }
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please, enter a positive number!");
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
