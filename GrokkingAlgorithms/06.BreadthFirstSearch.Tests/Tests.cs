using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace _06.BreadthFirstSearch.Tests
{
    public class Tests
    {
        [Test]
        public void BreadthFirstSearch_Should_ReturnTheExpectedValue_When_SellerExists()
        {
            // Arrange
            var expected = "Thom";
            var graph = new Dictionary<string, string[]>
            {
                ["You"] = new[] { "Alice", "Bob", "Claire" },
                ["Bob"] = new[] { "Anuj", "Peggy" },
                ["Alice"] = new[] { "Peggy" },
                ["Claire"] = new[] { "Thom", "Jonny" },
                ["Anuj"] = Array.Empty<string>(),
                ["Peggy"] = Array.Empty<string>(),
                ["Thom"] = Array.Empty<string>(),
                ["Jonny"] = Array.Empty<string>()
            };

            // check whether last letter is equal to 'm'
            Func<string, bool> isSelletFunc = s => s[^1] == 'm';

            // Act
            var (found, actual) = Algorithms.Search(graph, isSelletFunc, "You");

            // Assert
            Assert.IsTrue(found);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BreadthFirstSearch_Should_ReturnTheExpectedValue_When_NoSellerExists()
        {
            // Arrange
            var expected = string.Empty;
            var graph = new Dictionary<string, string[]>
            {
                ["You"] = new[] { "Alice", "Bob", "Claire" },
                ["Bob"] = new[] { "Anuj", "Peggy" },
                ["Alice"] = new[] { "Peggy" },
                ["Claire"] = new[] { "Thom", "Jonny" },
                ["Anuj"] = Array.Empty<string>(),
                ["Peggy"] = Array.Empty<string>(),
                ["Thom"] = Array.Empty<string>(),
                ["Jonny"] = Array.Empty<string>()
            };

            // check whether last letter is equal to 'z'
            Func<string, bool> isSelletFunc = s => s[^1] == 'z';

            // Act
            var (found, actual) = Algorithms.Search(graph, isSelletFunc, "You");

            // Assert
            Assert.IsFalse(found);
            Assert.AreEqual(expected, actual);
        }
    }
}