using Algorithms.DataStructures;
using Algorithms.Graphs;

namespace Tests.Graphs;

public class GraphPathFinderTests
{
    [Fact]
    public void Should_find_shortest_path()
    {
        // arrange
        var start = new Vertex("start");
        var a = new Vertex("a");
        var b = new Vertex("b");
        var c = new Vertex("c");
        var end = new Vertex("end");

        start.Neighbors = [b];
        a.Neighbors = [b, c, end];
        b.Neighbors = [start, a, c];
        c.Neighbors = [b, a, end];
        end.Neighbors = [a, c];

        // act
        var path = GraphPathFinder.FindPathUndirectedUnweighted(start, end, 10);

        // assert
        path.Should().ContainInConsecutiveOrder([start, b, a, end]);
    }
}
