namespace Algorithms.Graphs.Dijkstra;

public struct Edge
{
    public Vertex End { get; }
    public int Distance { get; }

    public Edge(Vertex end, int distance)
    {
        End = end;
        Distance = distance;
    }
}
