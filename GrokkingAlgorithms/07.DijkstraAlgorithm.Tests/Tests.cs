using NUnit.Framework;
using System.Collections.Generic;

namespace _07.DijkstraAlgorithm.Tests
{
    public class Tests
    {
        [Test]
        public void Dijkstra_Should_ReturnsTheExpectedCost()
        {
            // Arrange
            const int expectedCost = 6;
            var graph = BuildGraph();

            // Act
            var (actualCost, _) = Algorithms.Dijkstra(graph);

            // Assert
            Assert.AreEqual(expectedCost, actualCost);
        }

        [Test]
        public void Dijkstra_Should_ReturnsTheExpectedPath()
        {
            // Arrange
            const string expectedPath = "Start > B > A > Finish";

            var graph = BuildGraph();

            // Act
            var (_, actualPath) = Algorithms.Dijkstra(graph);

            // Assert
            Assert.AreEqual(expectedPath, actualPath);
        }


        Dictionary<string, Dictionary<string, int>> BuildGraph()
        {
            var graph = new Dictionary<string, Dictionary<string, int>>();
            graph["Start"] = new Dictionary<string, int>();
            graph["Start"]["A"] = 6;
            graph["Start"]["B"] = 2;

            graph["A"] = new Dictionary<string, int>();
            graph["A"]["Finish"] = 1;

            graph["B"] = new Dictionary<string, int>();
            graph["B"]["A"] = 3;
            graph["B"]["Finish"] = 5;

            graph["Finish"] = new Dictionary<string, int>();

            return graph;
        }
    }
}