namespace _06.BreadthFirstSearch
{
    public class Algorithms
    {
        public static (bool found, string seller) Search(Dictionary<string, string[]> graph, Func<string, bool> isSellerFunc, string name)
        {
            var searchQueue = new Queue<string>();

            var neighbors = graph[name];
            foreach (var neighbor in neighbors)
            {
                searchQueue.Enqueue(neighbor);
            }

            var searched = new List<string>();                          // This list is how you keep track of which people you have searched before

            while (searchQueue.Count > 0)
            {
                var person = searchQueue.Dequeue();
                if (!searched.Contains(person))                         // Only search this person if you haven't already searched them
                {
                    if (isSellerFunc(person))                               // Checks whether the person is a mango seller
                    {
                        return (true, person);
                    }
                    else
                    {
                        searched.Add(person);                           // Marks this person as searched
                        neighbors = graph[person];
                        foreach (var neighbor in neighbors)
                        {
                            searchQueue.Enqueue(neighbor);
                        }
                    }
                }
            }

            return (false, string.Empty);
        }
    }
}