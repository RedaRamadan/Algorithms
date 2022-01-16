using NUnit.Framework;

namespace _01.BinarySearch.Tests
{
    public class Tests
    {
        [TestCase(new int[] { 10, 20, 30, 40, 50 }, 10, 0)]
        [TestCase(new int[] { 10, 20, 30, 40, 50 }, 20, 1)]
        [TestCase(new int[] { 10, 20, 30, 40, 50 }, 30, 2)]
        [TestCase(new int[] { 10, 20, 30, 40, 50 }, 40, 3)]
        [TestCase(new int[] { 10, 20, 30, 40, 50 }, 50, 4)]
        public void BinarySearch_Should_ReturnsTheExpectedKeyIndex_When_KeyExists(int[] array, int key, int expected)
        {
            // Arrange
            // Act
            var actual = Algorithms.BinarySearch(array, key);

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 10, 20, 30, 40, 50 }, -10, -1)]
        [TestCase(new int[] { 10, 20, 30, 40, 50 }, 5, -1)]
        [TestCase(new int[] { 10, 20, 30, 40, 50 }, 15, -1)]
        [TestCase(new int[] { 10, 20, 30, 40, 50 }, 55, -1)]
        [TestCase(new int[] { 10, 20, 30, 40, 50 }, 100, -1)]
        public void BinarySearch_Should_ReturnsTheExpectedKeyIndex_When_KeyDoesNotExist(int[] array, int key, int expected)
        {
            // Arrange
            // Act
            var actual = Algorithms.BinarySearch(array, key);

            // Assert
            Assert.AreEqual(expected, actual);
        }



        [TestCase(new int[] { 10, 20, 30, 40, 50 }, 10, 0)]
        [TestCase(new int[] { 10, 20, 30, 40, 50 }, 20, 1)]
        [TestCase(new int[] { 10, 20, 30, 40, 50 }, 30, 2)]
        [TestCase(new int[] { 10, 20, 30, 40, 50 }, 40, 3)]
        [TestCase(new int[] { 10, 20, 30, 40, 50 }, 50, 4)]
        public void BinarySearchRecursive_Should_ReturnsTheExpectedKeyIndex_When_KeyExists(int[] array, int key, int expected)
        {
            // Arrange
            // Act
            var actual = Algorithms.BinarySearchRecursive(array, key);

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 10, 20, 30, 40, 50 }, -10, -1)]
        [TestCase(new int[] { 10, 20, 30, 40, 50 }, 5, -1)]
        [TestCase(new int[] { 10, 20, 30, 40, 50 }, 15, -1)]
        [TestCase(new int[] { 10, 20, 30, 40, 50 }, 55, -1)]
        [TestCase(new int[] { 10, 20, 30, 40, 50 }, 100, -1)]
        public void BinarySearchRecursive_Should_ReturnsTheExpectedKeyIndex_When_KeyDoesNotExist(int[] array, int key, int expected)
        {
            // Arrange
            // Act
            var actual = Algorithms.BinarySearchRecursive(array, key);

            // Assert
            Assert.AreEqual(expected, actual);
        }



        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(4, 2)]
        [TestCase(6, 2)]
        [TestCase(9, 3)]
        [TestCase(12, 3)]
        [TestCase(100, 10)]
        [TestCase(2147395599, 46339)]
        public void Sqrt_Should_ReturnsTheExpectedSqrt(int key, int expected)
        {
            // Arrange
            // Act
            var actual = Algorithms.Sqrt(key);

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}