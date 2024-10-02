namespace Algorithms.Graphs.Dijkstra;

public static class DijkstraFinder
{
    /// <summary>
    /// Finds the cheapest path in the given graph.
    /// </summary>
    /// <param name="graph">The graph to find the cheapest path in.</param>
    /// <returns>A dictionary containing the cheapest path, where the key is the vertex and the value is a tuple
    /// containing the distance and the parent vertex.</returns>
    public static Dictionary<Vertex, (int Distance, Vertex Parent)> FindCheapestPath(List<Vertex> graph)
    {
        var start = graph[0];
        var finish = graph[^1];
        var distances = new Dictionary<Vertex, (int Distance, Vertex Parent)> { { start, (0, start) } };
        var remainingVertices = graph.ToHashSet();

        while (remainingVertices.Count > 0)
        {
            var (minDistance, minVertex) = MinDistance(start, remainingVertices, distances);
            var currentVertexDistance = minDistance == int.MaxValue ? 0 : minDistance;

            foreach (var edge in minVertex.Edges)
            {
                var edgeEndDistanceInfo = distances.TryGetValue(edge.End, out var info)
                    ? info
                    : (Distance: int.MaxValue, Parent: finish);

                var shortestDistanceToEdgeEnd = edgeEndDistanceInfo.Distance;
                var fullCurrentDistance = currentVertexDistance + edge.Distance;

                if (fullCurrentDistance >= shortestDistanceToEdgeEnd) continue;

                edgeEndDistanceInfo.Distance = fullCurrentDistance;
                edgeEndDistanceInfo.Parent = minVertex;
                distances[edge.End] = edgeEndDistanceInfo;
            }

            remainingVertices.Remove(minVertex);
        }

        return distances;
    }

    private static (int MinDistance, Vertex MinVertex) MinDistance(
        Vertex startVertex,
        HashSet<Vertex> vertices,
        Dictionary<Vertex, (int Distance, Vertex Parent)> currentDistances)
    {
        var minDistance = int.MaxValue;
        var minVertex = startVertex;

        foreach (var vertex in vertices)
        {
            var distanceToVertex = currentDistances
                .TryGetValue(vertex, out var info)
                ? info.Distance
                : int.MaxValue;

            if (distanceToVertex >= minDistance) continue;

            minDistance = distanceToVertex;
            minVertex = vertex;
        }

        return (minDistance, minVertex);
    }
}
