using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Fibonacci
    {
        private List<long> FibonacciSequence = new List<long>()
            {
                0, 1
            };
        // this method takes an index as a parameter and returns the fibonacci number at that index.
        public long RetrieveFibonacciNumberAtIndex(int fibonacciIndex)
        {


            if (fibonacciIndex <= 2)
            {
                return FibonacciSequence[fibonacciIndex - 1];
            }

            BuildFibonacciSequence(fibonacciIndex);

            return FibonacciSequence.Last();

            // fibonacciSequence.Add(fibonacciSequence[0] + fibonacciSequence[1]);
            //fibonacciSequence.Add(fibonacciSequence[1] + fibonacciSequence[2]);
            //fibonacciSequence.Add(fibonacciSequence[2] + fibonacciSequence[3]);
            //fibonacciSequence.Add(fibonacciSequence[3] + fibonacciSequence[4]);

            //fibonacciSequence.ForEach(f => Console.Write(f + " ")); //assigning f to member of of fib seq list
            //Console.WriteLine();
            //Console.WriteLine(fibonacciSequence[3]); //this is what we used to access numbers of a list with an index
            //Console.ReadLine();


            //if (fibonacciIndex <= 1)
            //{
            //    return fibonacciIndex;
            //}
            //else
            //{
            //    return Retrieve(fibonacciIndex - 1) + Retrieve(fibonacciIndex - 2);
            //}

        }

        public List<long> RetrieveFibonacciSequenceAtIndex(int fibonacciIndex)
        {
            BuildFibonacciSequence(fibonacciIndex);
            return FibonacciSequence;
        }

        private void BuildFibonacciSequence(int fibonacciIndex)
        {
            for (int i = 2; i < fibonacciIndex; i++)
            {
                FibonacciSequence.Add(FibonacciSequence[i - 1] + FibonacciSequence[i - 2]);
            }
        }
    }
}


















