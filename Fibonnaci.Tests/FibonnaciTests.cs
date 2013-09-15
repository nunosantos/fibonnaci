using  NUnit.Framework;

namespace Fibonnaci.Tests
{
    [TestFixture]
    public class FibonnaciTests
    {
        private FibonnaciReader _objFibonnaci = null;

        [SetUp]
        public void SetUp()
        {
            _objFibonnaci = new FibonnaciReader();
        }

        [Test]
        public void Evaluate_ValidSequence()
        {
            //act
            const int number = 3;
            var arrayOfNumbers = new double[number];
            arrayOfNumbers[0] = 0;
            arrayOfNumbers[1] = 1;
            _objFibonnaci.Evaluate(number, arrayOfNumbers);
            const double expected = 1;
            double actual = arrayOfNumbers[2];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TearDown]
        public void TearDown()
        {
            _objFibonnaci = null;
        }
    }
}
