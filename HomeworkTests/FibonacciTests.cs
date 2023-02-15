using Homework;

namespace HomeworkTests
{
    public class Tests
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
            var result = _fibonacci.Retrieve(fibonacciIndex);
            
            Assert.AreEqual(expectedResult, result);
        }
    }
}