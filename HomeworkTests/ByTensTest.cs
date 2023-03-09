using Homework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTests
{
    public class ByTensTest
    {
        private ByTens _byTens;

        [SetUp]

        public void Setup()
        {
            _byTens = new ByTens();
        }

       
       [Test]
       public void ByTens_Returns_True_When_The_Number_Is_Divisible_By_10()
        {    //arrange 
                 //act 
                 //assert 

        var result = _byTens.IsDivisibleByTen(0);
        Assert.IsFalse(result);

        }
        [Test]
        public void ByTens_Returns_False_When_The_Number_Is_Not_Divisible_By_10()
        {    //arrange 
            //act
            //assert 

            var result = _byTens.Equals(false);
            Assert.IsFalse(result);

        }
        [Test]
        public void Retrieve_Returns_0_When_Index_Is_0()
        {    //arrange 
            //act
            //assert 

            var result = _byTens.Retrieve(0);
            Assert.That(result, Is.EqualTo(0));

        }
        [Test]
        public void Retrieve_Returns_10_When_Index_Is_1()
        {    //arrange 
            //act
            //assert 

            var result = _byTens.Retrieve(1);
            Assert.That(result, Is.EqualTo(10));

        }

        [Test]
        public void Retrieve_Returns_20_When_Index_Is_2()
        {    //arrange 
            //act
            //assert 

            var result = _byTens.Retrieve(2);
            Assert.That(result, Is.EqualTo(20));

        }
        [Test]
        public void Retrieve_Returns_80_When_Index_Is_8()
        {    //arrange 
            //act
            //assert 

            var result = _byTens.Retrieve(8);
            Assert.That(result, Is.EqualTo(80));

        }
        [Test]
        public void Retrieve_Returns_110_When_Index_Is_11()
        {    //arrange 
            //act
            //assert 

            var result = _byTens.Retrieve(11);
            Assert.That(result, Is.EqualTo(110));

        }
        [Test]
        public void Retrieve_Returns_500_When_Index_Is_50()
        {    //arrange 
            //act
            //assert 

            var result = _byTens.Retrieve(50);
            Assert.That(result, Is.EqualTo(500));

        }
        [Test]
        public void Retrieve_Returns_1000_When_Index_Is_100()
        {    //arrange 
            //act
            //assert 

            var result = _byTens.Retrieve(100);
            Assert.That(result, Is.EqualTo(1000));

        }







    }
}





