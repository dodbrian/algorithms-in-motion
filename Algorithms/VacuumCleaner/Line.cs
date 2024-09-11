namespace Algorithms.VacuumCleaner;

public record Line(Point Start, Point End)
{
    public Line(int startX, int startY, int endX, int endY) : this(new(startX, startY), new(endX, endY))
    {
    }

    public int Length => Math.Abs(End.X - Start.X) + Math.Abs(End.Y - Start.Y) + 1;
    public LineOrientation Orientation => End.X == Start.X ? LineOrientation.Vertical : LineOrientation.Horizontal;

    public static Line Merge(Line a, Line b)
    {
        if (a.Orientation != b.Orientation) throw new InvalidOperationException();

        var lineA = NormalizeLine(a);
        var lineB = NormalizeLine(b);

        if (!lineA.Intersects(lineB)) throw new InvalidOperationException();

        Line mergedLine = lineA.Orientation switch
        {
            LineOrientation.Horizontal => new(
                Math.Min(lineA.Start.X, lineB.Start.X),
                lineA.Start.Y,
                Math.Max(lineA.End.X, lineB.End.X),
                lineA.Start.Y),
            LineOrientation.Vertical => new(
                lineA.Start.X,
                Math.Min(lineA.Start.Y, lineB.Start.Y),
                lineA.Start.X,
                Math.Max(lineA.End.Y, lineB.End.Y)),
            _ => throw new InvalidOperationException()
        };

        return mergedLine;
    }

    public bool Intersects(Line other) => IntersectsBase(this, other) || IntersectsBase(other, this);

    private static bool IntersectsBase(Line a, Line b) =>
        ((a.Start.X <= b.Start.X && b.Start.X <= a.End.X) ||
         (a.Start.X >= b.Start.X && b.Start.X >= a.End.X)) &&
        ((b.End.Y >= a.Start.Y && a.Start.Y >= b.Start.Y) ||
         (b.End.Y <= a.Start.Y && a.Start.Y <= b.Start.Y));

    public int GetCommonPoints(Line other)
    {
        var lineA = NormalizeLine(this);
        var lineB = NormalizeLine(other);

        var right = lineB.End.X < lineA.End.X ? lineB.End.X : lineA.End.X;
        var left = lineB.Start.X > lineA.Start.X ? lineB.Start.X : lineA.Start.X;
        var top = lineB.End.Y < lineA.End.Y ? lineB.End.Y : lineA.End.Y;
        var bottom = lineB.Start.Y > lineA.Start.Y ? lineB.Start.Y : lineA.Start.Y;

        var width = right - left + 1;
        if (width < 1) return 0;

        var height = top - bottom + 1;
        if (height < 1) return 0;

        return width * height;
    }

    private static Line NormalizeLine(Line a)
    {
        // normalize the lines
        int asx, aex, asy, aey;

        if (a.Start.X < a.End.X)
        {
            asx = a.Start.X;
            aex = a.End.X;
        }
        else
        {
            asx = a.End.X;
            aex = a.Start.X;
        }

        if (a.Start.Y < a.End.Y)
        {
            asy = a.Start.Y;
            aey = a.End.Y;
        }
        else
        {
            asy = a.End.Y;
            aey = a.Start.Y;
        }

        return new(asx, asy, aex, aey);
    }
}
