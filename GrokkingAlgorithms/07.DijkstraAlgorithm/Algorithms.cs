namespace _07.DijkstraAlgorithm
{
    public class Algorithms
    {
        const int Infinity = int.MaxValue;

        public static (int cost, string path) Dijkstra(Dictionary<string, Dictionary<string, int>> graph)
        {
            var costs = GetCostsDictionary(graph);
            var parents = GetParentsDictionary(graph);
            var processed = new List<string>();

            // Dijkstra algorithm..
            string FindLowestCostNode(Dictionary<string, int> costs)
            {
                var lowest_cost = Infinity;
                var lowest_cost_node = string.Empty;

                foreach (var (node, cost) in costs)                             // Go through each node.
                {
                    if (cost < lowest_cost && !processed.Contains(node))        // If it's the lowest cost so far and hasn't been processed yet
                    {
                        lowest_cost = cost;                                     // set it as the new lowest-cost node
                        lowest_cost_node = node;
                    }
                }

                return lowest_cost_node;
            }

            var node = FindLowestCostNode(costs);                   // Find the lowest-cost node that you haven't processed yet.
            while (!string.IsNullOrEmpty(node))                     // If you have processed all the nodes, this while loop is done.
            {
                var cost = costs[node];
                var neighbors = graph[node];
                foreach (var n in neighbors.Keys)                   // Go through all the neighbors of this node.
                {
                    var new_cost = cost + neighbors[n];             // If it's cheaper to get to this neighbor
                    if (costs[n] > new_cost)                        // by going through this node
                    {
                        costs[n] = new_cost;                        // update the cost for this node.
                        parents[n] = node;                          // This node becomes the new parent for this neighbor.
                    }
                }
                processed.Add(node);                                // Mark the node as processed.
                node = FindLowestCostNode(costs);                   // Find the next node to process, and loop.
            }

            var final_cost = costs["Finish"];
            var final_path = BuildPath(parents);
            return (final_cost, final_path);
        }

        private static Dictionary<string, int> GetCostsDictionary(Dictionary<string, Dictionary<string, int>> graph)
        {
            // prep costs dictionary
            var costs = new Dictionary<string, int>();

            foreach (var key in graph["Start"].Keys)
            {
                costs[key] = graph["Start"][key];
            }
            costs["Finish"] = Infinity;

            return costs;
        }

        private static Dictionary<string, string> GetParentsDictionary(Dictionary<string, Dictionary<string, int>> graph)
        {
            // prep parents dictionary
            var parents = new Dictionary<string, string>();

            foreach (var key in graph["Start"].Keys)
            {
                parents[key] = "Start";
            }
            parents["Finish"] = string.Empty;

            return parents;
        }

        private static string BuildPath(Dictionary<string, string> parents)
        {
            var stack = new Stack<string>();

            var node = parents["Finish"];
            stack.Push("Finish");
            while (!string.IsNullOrEmpty(node))
            {
                stack.Push(node);
                if (parents.ContainsKey(node))
                {
                    node = parents[node];
                }
                else
                {
                    node = null;
                }
            }

            string path = "";
            while (stack.Count > 0)
            {
                path += $"{stack.Pop()} > ";
            }
            path = path.Substring(0, path.Length - 3);

            return path;
        }
    }
}