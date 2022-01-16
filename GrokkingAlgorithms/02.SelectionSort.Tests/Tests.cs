using NUnit.Framework;

namespace _02.SelectionSort.Tests
{
    public class Tests
    {
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 5 }, new int[] { 5 })]
        [TestCase(new int[] { 5, 4 }, new int[] { 4, 5 })]
        [TestCase(new int[] { 5, 4, 3 }, new int[] { 3, 4, 5 })]
        [TestCase(new int[] { 5, 4, 3, 2 }, new int[] { 2, 3, 4, 5 })]
        [TestCase(new int[] { 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 5, 4, 3, 2, 1, 0 }, new int[] { 0, 1, 2, 3, 4, 5 })]
        public void SelectionSort_Should_SortTheArrayInAscendingOrder(int[] array, int[] expected)
        {
            // Arrange
            // Act
            Algorithms.SeletionSort(array);

            // Assert
            CollectionAssert.AreEqual(expected, array);
        }
    }
}