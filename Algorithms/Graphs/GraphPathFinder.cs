using Algorithms.DataStructures;

namespace Algorithms.Graphs;

public static class GraphPathFinder
{
    public static List<Vertex> FindPathUndirectedUnweighted(Vertex start, Vertex end, int limit)
    {
        var predecessors = new Dictionary<Vertex, Vertex?>
        {
            { start, null }
        };

        var queue = new Queue<Vertex>();
        queue.Enqueue(start);

        while (queue.Count > 0)
        {
            var vertex = queue.Dequeue();
            if (vertex == end)
            {
                var path = new List<Vertex>();

                while (vertex is not null)
                {
                    path.Add(vertex);
                    vertex = predecessors[vertex];
                }

                if (path.Count > limit) return [];

                path.Reverse();
                return path;
            }

            foreach (var neighbor in vertex.Neighbors
                         .Where(neighbor => predecessors.TryAdd(neighbor, vertex)))
            {
                queue.Enqueue(neighbor);
            }
        }

        return [];
    }
}