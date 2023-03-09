using Homework;

namespace HomeworkTests
{
    public class FibonacciTests
    {
        private Fibonacci _fibonacci;

        [SetUp]
        public void Setup()
        {
            _fibonacci = new Fibonacci();
        }

        [TestCase(1, 0)]
        [TestCase(2, 1)]
        [TestCase(3, 1)]
        [TestCase(4, 2)]
        [TestCase(5, 3)]
        [TestCase(6, 5)]
        [TestCase(7, 8)]
        [TestCase(8, 13)]
        [TestCase(9, 21)]
        [TestCase(10, 34)]
        [TestCase(11, 55)]
        [TestCase(12, 89)]
        [TestCase(13, 144)]
        [TestCase(14, 233)]
        [TestCase(15, 377)]
        public void Retrieve_Returns_Correct_Response(int fibonacciIndex, long expectedResult)
        {
            var result = _fibonacci.RetrieveFibonacciNumberAtIndex(fibonacciIndex);
            
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void RetrieveFibonacciSequenceAtIndex_Returns_Correct_Response()
        { //arrange
            var expectedList = new List<long>()
            {
                0, 1, 1, 2, 3, 5, 8, 13, 21, 34
            };
            // act
           var result = _fibonacci.RetrieveFibonacciSequenceAtIndex(10);
            // assert
            Assert.AreEqual(expectedList, result);
        }
        [Test]
        public void RetrieveFibonacciSequenceAtIndex_Returns_Correct_Response_Again()
        { //arrange
            var expectedList = new List<long>()
            {
                0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377
            };
            // act
            var result = _fibonacci.RetrieveFibonacciSequenceAtIndex(15);
            // assert
            Assert.AreEqual(expectedList, result);
        }
        [Test]
        public void RetrieveFibonacciSequenceAtIndex_Returns_Correct_Response_Again_and_Again()
        { //arrange
            var expectedList = new List<long>()
            {
                0, 1, 1
            };
            // act
            var result = _fibonacci.RetrieveFibonacciSequenceAtIndex(3);
            // assert
            Assert.AreEqual(expectedList, result);
        }
    }
}