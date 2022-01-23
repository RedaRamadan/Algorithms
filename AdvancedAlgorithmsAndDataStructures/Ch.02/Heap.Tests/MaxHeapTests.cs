using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Heap.Tests
{
    public class MaxHeapTests
    {
        [TestCase(new int[] { 1 }, 1)]
        [TestCase(new int[] { 1, 2 }, 2)]
        [TestCase(new int[] { 1, 2, 3 }, 3)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 4)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 6)]
        public void Top_Should_ReturnTheMaxValue(int[] array, int expected)
        {
            // Arrange
            var maxHeap = new MaxHeap();
            foreach (var num in array)
            {
                maxHeap.Add(num.ToString(), num);
            }

            // Act
            var actual = maxHeap.Top();

            // Assert
            Assert.AreEqual(expected, actual.Priority);
        }

        [Test]
        public void MaxHeap_Should_OrderElementsByPriority()
        {
            // Arrange
            var pairs = new List<Pair>
            {
                new Pair("Page loads take 2+ seconds", 7),
                new Pair("Refactor CSS using SASS", 3),
                new Pair("Unencrypted password on DB", 10),
                new Pair("CSS style causes misalignment", 4),
                new Pair("Optional from field blocked", 8),
                new Pair("Memory leak", 9)
            };
            var expected = new string[]
            {
                "Unencrypted password on DB",
                "Memory leak",
                "Optional from field blocked",
                "Page loads take 2+ seconds",
                "CSS style causes misalignment",
                "Refactor CSS using SASS"
            };

            var maxHeap = new MaxHeap();
            foreach (var p in pairs)
            {
                maxHeap.Add(p.Element, p.Priority);
            }

            // Act
            var actual = new string[pairs.Count];
            int i = 0;
            while (maxHeap.Size() > 0)
            {
                actual[i] = maxHeap.Top().Element;
                i++;
            }

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void Top_Should_ThrowsInvalidOperationException_When_HeapIsEmpty()
        {
            // Arrange
            var maxHeap = new MaxHeap();

            // Act
            void Act()
            {
                maxHeap.Top();
            }

            // Assert
            Assert.Throws<InvalidOperationException>(Act);
        }
    }
}