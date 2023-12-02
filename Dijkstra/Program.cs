var start = new Vertex("Start");
var a = new Vertex("A");
var b = new Vertex("B");
var c = new Vertex("C");
var d = new Vertex("D");
var finish = new Vertex("Finish");

start.Edges = new List<Edge>
{
    new(a, 3),
    new(b, 7)
};

a.Edges = new List<Edge>
{
    new(b, 2),
    new(c, 5),
    new(d, 6),
};

b.Edges = new List<Edge>
{
    new(c, 2),
    new(d, 6),
};

c.Edges = new List<Edge>
{
    new(d, 1),
    new(finish, 9),
};

d.Edges = new List<Edge>
{
    new(finish, 7),
};

var graph = new List<Vertex> { start, a, b, c, d, finish };
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

        if (fullCurrentDistance < shortestDistanceToEdgeEnd)
        {
            edgeEndDistanceInfo.Distance = fullCurrentDistance;
            edgeEndDistanceInfo.Parent = minVertex;
            distances[edge.End] = edgeEndDistanceInfo;
        }
    }

    remainingVertices.Remove(minVertex);
}

foreach (var distance in distances)
    Console.WriteLine($"{distance.Key}: {distance.Value.Distance} from {distance.Value.Parent}");

return;

(int MinDistance, Vertex MinVertex) MinDistance(
    Vertex startVertex,
    HashSet<Vertex> vertices,
    IReadOnlyDictionary<Vertex, (int Distance, Vertex Parent)> currentDistances)
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

internal class Vertex
{
    private string Name { get; }
    public List<Edge> Edges { get; set; } = new();

    public Vertex(string name) => Name = name;

    public override string ToString() => Name;
}

internal struct Edge
{
    public Vertex End { get; }
    public int Distance { get; }

    public Edge(Vertex end, int distance)
    {
        End = end;
        Distance = distance;
    }
}
