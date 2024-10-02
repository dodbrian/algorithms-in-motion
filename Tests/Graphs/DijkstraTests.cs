using Algorithms.Graphs.Dijkstra;

namespace Tests.Graphs;

public class DijkstraTests
{
    [Fact]
    public void Should_find_cheapest_path()
    {
        // arrange
        var start = new Vertex("Start");
        var a = new Vertex("A");
        var b = new Vertex("B");
        var c = new Vertex("C");
        var d = new Vertex("D");
        var finish = new Vertex("Finish");

        start.Edges =
        [
            new(a, 3),
            new(b, 7)
        ];

        a.Edges =
        [
            new(b, 2),
            new(c, 5),
            new(d, 6)
        ];

        b.Edges =
        [
            new(c, 2),
            new(d, 6)
        ];

        c.Edges =
        [
            new(d, 1),
            new(finish, 9)
        ];

        d.Edges = [new(finish, 7)];

        List<Vertex> graph = [start, a, b, c, d, finish];

        var expected = new Dictionary<Vertex, (int Distance, Vertex Parent)>
        {
            { start, (0, start) },
            { a, (3, start) },
            { b, (5, a) },
            { c, (7, b) },
            { d, (8, c) },
            { finish, (15, d) },
        };

        // act
        var path = DijkstraFinder.FindCheapestPath(graph);

        // assert
        path.Should().BeEquivalentTo(expected);
    }
}
