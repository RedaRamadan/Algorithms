using NUnit.Framework;

namespace _04.MergeSort.Tests
{
    public class Tests
    {
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { 2, 1 }, new int[] { 1, 2 })]
        [TestCase(new int[] { 3, 2, 1 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 6, 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5, 6 })]
        public void MergeSort_Inplace_ShouldSortTheArrayInAscendingOrder(int[] array, int[] expected)
        {
            // Arrange
            // Act
            Algorithms.MergeSort_Inplace(array);

            // Assert
            CollectionAssert.AreEqual(expected, array);
        }


        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { 2, 1 }, new int[] { 1, 2 })]
        [TestCase(new int[] { 3, 2, 1 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 6, 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5, 6 })]
        public void MergeSort_ShouldSortTheArrayInAscendingOrder(int[] array, int[] expected)
        {
            // Arrange
            // Act
            Algorithms.MergeSort(array);

            // Assert
            CollectionAssert.AreEqual(expected, array);
        }
    }
}