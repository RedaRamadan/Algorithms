using NUnit.Framework;

namespace _04.QuickSort.Tests
{
    public class Tests
    {
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { 2, 1 }, new int[] { 1, 2 })]
        [TestCase(new int[] { 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 6, 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5, 6 })]
        [TestCase(new int[] { 7, 6, 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5, 6, 7 })]
        [TestCase(new int[] { 8, 7, 6, 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        public void Quicksort_Should_ShouldSortTheArrayInAscendingOrder(int[] array, int[] expected)
        {
            // Arrange
            // Act
            Algorithms.Quicksort(array);

            // Assert
            CollectionAssert.AreEqual(expected, array);
        }
    }
}