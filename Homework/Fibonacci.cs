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
   
        // this method takes an index as a parameter and returns the fibonacci number at that index.
        public long Retrieve(int fibonacciIndex)
        {
            if (fibonacciIndex <= 1)
            {
                return fibonacciIndex;
            }
            else
            {
                return Retrieve(fibonacciIndex - 1) + Retrieve(fibonacciIndex - 2);
            }
        }
    }
}


















