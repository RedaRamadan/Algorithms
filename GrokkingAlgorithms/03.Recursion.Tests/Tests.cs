using NUnit.Framework;

namespace _03.Recursion.Tests
{
    public class Tests
    {
        [TestCase(0, 1)]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 6)]
        [TestCase(4, 24)]
        [TestCase(5, 120)]
        public void Factorial_Should_ReturnsTheExpectedFactorial(int n, int expected)
        {
            // Arrange
            // Act
            var actual = Algorithms.Factorial(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}