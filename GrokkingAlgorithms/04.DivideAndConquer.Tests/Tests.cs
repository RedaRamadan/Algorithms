using NUnit.Framework;

namespace _04.DivideAndConquer.Tests
{
    public class Tests
    {
        [TestCase(4, 2, 2)]
        [TestCase(1680, 640, 80)]
        [TestCase(80, 3, 1)]
        public void SquarePlots_Should_ReturnTheExpectedValue(int a, int b, int expected)
        {
            // Arrange
            // Act
            var actual = Algorithms.SquarePlots(a, b);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 0, 1 }, 1)]
        [TestCase(new int[] { 0, 1, 2 }, 3)]
        [TestCase(new int[] { 0, 1, 2, 3 }, 6)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 10)]
        public void SumArrayByLoops_Should_ReturnsTheExpectedTotal(int[] array, int expected)
        {
            // Arrange
            // Act
            var actual = Algorithms.SumArrayByLoops(array);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 0, 1 }, 1)]
        [TestCase(new int[] { 0, 1, 2 }, 3)]
        [TestCase(new int[] { 0, 1, 2, 3 }, 6)]
        [TestCase(new int[] { 0, 1, 2, 3, 4 }, 10)]
        public void SumArrayByRecursive_Should_ReturnsTheExpectedTotal(int[] array, int expected)
        {
            // Arrange
            // Act
            var actual = Algorithms.SumArrayByRecursive(array);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] { 0 }, 1)]
        [TestCase(new int[] { 0, 1 }, 2)]
        [TestCase(new int[] { 0, 1, 2 }, 3)]
        [TestCase(new int[] { 0, 1, 2, 3 }, 4)]
        [TestCase(new int[] { 0, 1, 2, 3, 4 }, 5)]
        public void CountItemsByRecursive_Should_ReturnsTheExpectedCount(int[] array, int expected)
        {
            // Arrange
            // Act
            var actual = Algorithms.CountItemsByRecursive(array);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 0, 1 }, 1)]
        [TestCase(new int[] { 0, 1, 2 }, 2)]
        [TestCase(new int[] { 0, 1, 2, 3 }, 3)]
        [TestCase(new int[] { 0, 1, 2, 3, 4 }, 4)]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5 }, 5)]
        [TestCase(new int[] { 0, -1, -2, -3, -4, -5 }, 0)]
        public void FindMaxByRecursive_Should_ReturnsTheExpectedMax(int[] array, int expected)
        {
            // Arrange
            // Act
            int actual = Algorithms.FindMaxByRecursive(array);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0 }, 0, 0)]
        [TestCase(new int[] { 0, 1 }, 1, 1)]
        [TestCase(new int[] { 0, 1, 2 }, 2, 2)]
        [TestCase(new int[] { 0, 1, 2, 3 }, 3, 3)]
        [TestCase(new int[] { 0, 1, 2, 3, 4 }, 4, 4)]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5 }, 5, 5)]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5 }, 10, -1)]
        public void BinarySearchRecursive_Should_ReturnsTheExpectedResult(int[] array, int target, int expected)
        {
            // Arrange
            // Act
            int actual = Algorithms.BinarySearchByRecursive(array, target);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}