using NUnit.Framework;

namespace FibonacciSequenceTests
{
    [TestFixture]
    public class Sequencer
    {
        [Test]
        public void GetPositionOfOneShouldReturnZero()
        {
            var fibonacciSequencer = new FibonacciSequence.Sequencer();
            const int requestedPosition = 1;
            const int expectedResult = 0;

            var actualResult = fibonacciSequencer.GetPosition(requestedPosition);

            Assert.That(expectedResult.Equals(actualResult));
        }

        [Test]
        public void GetPositionOfTwoShouldReturnOne()
        {
            var fibonacciSequencer = new FibonacciSequence.Sequencer();
            const int requestedPosition = 2;
            const int expectedResult = 1;

            var actualResult = fibonacciSequencer.GetPosition(requestedPosition);

            Assert.That(expectedResult.Equals(actualResult));
        }

        [Test]
        public void GetPositionOfThreeShouldReturnOne()
        {
            var fibonacciSequencer = new FibonacciSequence.Sequencer();
            const int requestedPosition = 3;
            const int expectedResult = 1;

            var actualResult = fibonacciSequencer.GetPosition(requestedPosition);

            Assert.That(expectedResult.Equals(actualResult));
        }

        [Test]
        public void GetPositionOfFourShouldReturnTwo()
        {
            var fibonacciSequencer = new FibonacciSequence.Sequencer();
            const int requestedPosition = 4;
            const int expectedResult = 2;

            var actualResult = fibonacciSequencer.GetPosition(requestedPosition);

            Assert.That(expectedResult.Equals(actualResult));
        }

        [Test]
        public void GetPositionOfTenShouldReturnThirtyFour()
        {
            var fibonacciSequencer = new FibonacciSequence.Sequencer();
            const int requestedPosition = 10;
            const int expectedResult = 34;

            var actualResult = fibonacciSequencer.GetPosition(requestedPosition);

            Assert.That(expectedResult.Equals(actualResult));
        }
    }
}
