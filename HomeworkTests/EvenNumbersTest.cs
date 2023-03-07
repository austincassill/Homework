using Homework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTests
{
    public class EvenNumbersTest
    {
        private EvenNumbers _evenNumbers;



        [SetUp]
        public void Setup()
        {
            _evenNumbers = new EvenNumbers();
        }
        [Test]
        public void IsEven_Returns_True_When_The_Number_Is_Even()
        {    //arrange 
            //act 
            //assert 

            var result = _evenNumbers.IsEven(2);
            Assert.IsTrue(result);

        }
        [Test]
        public void IsEven_Returns_False_When_The_Number_Is_Zero()
        {    //arrange 
            //act
            //assert 

            var result = _evenNumbers.IsEven(0);
            Assert.IsFalse(result);

        }
        [Test]
        public void IsEven_Returns_False_When_The_Number_Is_Odd()
        {    //arrange 
            //act
            //assert 

            var result = _evenNumbers.IsEven(1);
            Assert.IsFalse(result);

        }
        [Test]
        public void Retrieve_Returns_2_When_Index_Is_1()
        {    //arrange 
            //act
            //assert 

            var result = _evenNumbers.Retrieve(1);
            Assert.That(result, Is.EqualTo(2));

        }
        [Test]
        public void Retrieve_Returns_4_When_Index_Is_2()
        {    //arrange 
            //act
            //assert 

            var result = _evenNumbers.Retrieve(2);
            Assert.That(result, Is.EqualTo(4));

        }
        [Test]
        public void Retrieve_Returns_8_When_Index_Is_4()
        {    //arrange 
            //act
            //assert 

            var result = _evenNumbers.Retrieve(4);
            Assert.That(result, Is.EqualTo(8));

        }

    }
}
