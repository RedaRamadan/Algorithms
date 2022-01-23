using NUnit.Framework;

namespace Heap.Tests
{
    public class ContainerTests
    {
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { 5, 4, 3, 2, 1 }, new int[] { 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { 50, 60, 70 }, new int[] { 70, 60, 50 })]
        [TestCase(new int[] { 70, 60, 50 }, new int[] { 70, 60, 50 })]
        public void Heapify_Should_BuildMaxHeap(int[] array, int[] expected)
        {
            // Arrange
            var container = new Container(array);

            // Act
            container.Heapify();
            var actual = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                actual[i] = container.Top();
            }

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}