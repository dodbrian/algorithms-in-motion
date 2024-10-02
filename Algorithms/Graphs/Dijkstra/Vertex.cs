namespace Algorithms.Graphs.Dijkstra;

public class Vertex
{
    private string Name { get; }
    public List<Edge> Edges { get; set; } = [];

    public Vertex(string name) => Name = name;

    public override string ToString() => Name;
}
