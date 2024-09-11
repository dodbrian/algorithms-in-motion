namespace Algorithms.Graphs;

// There are n cities. A province is a group of directly or indirectly connected cities
// and no other cities outside the group. You are given an n x n matrix isConnected
// where isConnected[i][j] = isConnected[j][i] = 1 if the i-th city and the j-th city
// are directly connected, and isConnected[i][j] = 0 otherwise. Return the total number of provinces.
public class NumberOfProvinces
{
    private List<int>[] _graph;
    private bool[] _seen;

    public int GetNumberOfProvinces(int[][] isConnected)
    {
        _seen = new bool[isConnected.Length];
        _graph = Prepare(isConnected);

        var count = 0;

        for (var i = 0; i < isConnected.Length; i++)
        {
            if (_seen[i]) continue;

            TraverseGraph(i);
            count++;
        }

        return count;
    }

    private void TraverseGraph(int node)
    {
        if (_seen[node]) return;

        _seen[node] = true;

        if (_graph[node] is null) return;

        foreach (var neighbor in _graph[node])
            TraverseGraph(neighbor);
    }

    private static List<int>[] Prepare(int[][] isConnected)
    {
        var graph = new List<int>[isConnected.Length];

        for (var i = 0; i < isConnected.Length; i++)
        {
            for (var j = 0; j < isConnected.Length; j++)
            {
                if (isConnected[i][j] == 0 && isConnected[j][i] == 0) continue;

                AddRelation(graph, i, j);
                AddRelation(graph, j, i);
            }
        }

        return graph;
    }

    private static void AddRelation(List<int>[] graph, int start, int end)
    {
        var neighbours = graph[start];
        if (neighbours is null)
            graph[start] = [end];
        else
            neighbours.Add(end);
    }
}
