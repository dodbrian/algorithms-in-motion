using System.Diagnostics;

namespace Algorithms.DataStructures;

[DebuggerDisplay("{Name}")]
public class Vertex(string name)
{
    public string Name { get; } = name;
    public List<Vertex> Neighbors { get; set; } = [];
}