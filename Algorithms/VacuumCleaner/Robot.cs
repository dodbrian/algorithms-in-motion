namespace Algorithms.VacuumCleaner;

public static class Robot
{
    public static IEnumerable<Line> CreateLines(int startX, int startY, IEnumerable<Command> commands)
    {
        var currX = startX;
        var currY = startY;

        return commands.Select(
            command =>
            {
                var endX = command.Direction switch
                {
                    Direction.East => currX + command.Distance,
                    Direction.West => currX - command.Distance,
                    _ => currX
                };

                var endY = command.Direction switch
                {
                    Direction.North => currY + command.Distance,
                    Direction.South => currY - command.Distance,
                    _ => currY
                };

                var line = new Line(currX, currY, endX, endY);

                currX = endX;
                currY = endY;

                return line;
            });
    }

    public static int CountUniquePlaces_Attempt1(IList<Line> lines)
    {
        var totalLength = lines.Sum(line => line.Length) - lines.Count + 1;
        var commonPoints = lines.Sum(
            line => lines
                .Where(otherLine => !ReferenceEquals(line, otherLine))
                .Sum(line.GetCommonPoints)) / 2;

        return totalLength - commonPoints;
    }

    public static int CountUniquePlaces(IList<Line> lines)
    {
        Dictionary<int, List<Line>> horizontalLines = new();
        Dictionary<int, List<Line>> verticalLines = new();

        foreach (var line in lines)
        {
            if (line.Orientation == LineOrientation.Horizontal)
            {
                var y = line.Start.Y;
                if (horizontalLines.TryGetValue(y, out var yLines))
                {
                    var currentLine = line;
                    for (var i = yLines.Count - 1; i >= 0; i--)
                    {
                        if (!line.Intersects(yLines[i])) continue;

                        currentLine = Line.Merge(line, yLines[i]);
                        yLines.RemoveAt(i);
                    }

                    yLines.Add(currentLine);
                }
                else
                {
                    horizontalLines.Add(y, [line]);
                }
            }
            else
            {
                var x = line.Start.X;
                if (verticalLines.TryGetValue(x, out var xLines))
                {
                    var currentLine = line;
                    for (var i = xLines.Count - 1; i >= 0; i--)
                    {
                        if (!line.Intersects(xLines[i])) continue;

                        currentLine = Line.Merge(line, xLines[i]);
                        xLines.RemoveAt(i);
                    }

                    xLines.Add(currentLine);
                }
                else
                {
                    verticalLines.Add(x, [line]);
                }
            }
        }

        var commonPoints = verticalLines.SelectMany(pair => pair.Value)
            .Sum(
                verticalLine => horizontalLines
                    .SelectMany(pair => pair.Value)
                    .Sum(verticalLine.GetCommonPoints));

        var totalLength = verticalLines.SelectMany(pair => pair.Value).Sum(line => line.Length) +
                          horizontalLines.SelectMany(pair => pair.Value).Sum(line => line.Length);

        return totalLength - commonPoints;
    }
}
