namespace BreadthFirstSearch
{
    internal class Program
    {
        static void BFS(Dictionary<int, List<int>> graph, int start)
        {
            var visited = new HashSet<int>();
            var queue = new Queue<int>();

            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();

                if (visited.Contains(node))
                    continue;

                visited.Add(node);
                Console.Write(node + " ");
                foreach (var neighbor in graph[node])
                    queue.Enqueue(neighbor);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Elham Bakrey Mohamed Khesha");

            var graph = new Dictionary<int, List<int>>()
            {
            {1, new List<int> {2, 3}},
            {2, new List<int> {4, 5}},
            {3, new List<int> {6}},
            {4, new List<int>()},
            {5, new List<int>()},
            {6, new List<int>()}
            };

            Console.WriteLine("BFS:");
            BFS(graph, 1);
            // Console.WriteLine("إلهام بكرى محمد خيشه");
            Console.ReadKey();
        }
    }
}
