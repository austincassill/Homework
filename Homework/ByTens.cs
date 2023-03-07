using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class ByTens
    {
        public bool IsNotDivisibleBy10 { get; set; }

        public bool IsDivisibleByTen(int value)
        {
            return value == 0 || value % 10 == 0;
        }
        public int Retrieve(int index)
        {
            return index * 10;
        }
    }
}
