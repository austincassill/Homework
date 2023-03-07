using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class EvenNumbers
    { //take a number as a parameter , return true or false 
        public bool IsEven(int value)
        {
            if (value == 0) return false;
            return (value % 2 == 0);
        }
        //method that takes number as parameter and returns index the even number at that index 
        public int Retrieve(int index)
        {
            return index * 2;
            //int result = 0;

            // for (int i = 1; i <= index; i++)
            //{
            //    result += 2;
            //}
            // return result;
        }
    }
}
