using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonachiIterator
{
   public class Fibonacci
    {
        public static IEnumerable<int> FibonacciSequence(int size)
        {
            int previous = 0;
            int current = 1;
            for(int i=1; i<size; i++)
            {
                yield return previous;
                int next = previous + current;
                previous = current;
                current = next;
            }
        }
    }
}
