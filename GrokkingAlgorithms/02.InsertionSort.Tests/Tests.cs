using NUnit.Framework;

namespace _02.InsertionSort.Tests
{
    public class Tests
    {
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { 2, 1 }, new int[] { 1, 2 })]
        [TestCase(new int[] { 3, 2, 1 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5 })]
        public void InsertionSort_ShouldSortTheArrayInAscendingOrder(int[] array, int[] expected)
        {
            // Arrange
            // Act
            Algorithms.InsertionSort(array);

            // Assert
            CollectionAssert.AreEqual(expected, array);
        }
    }
}