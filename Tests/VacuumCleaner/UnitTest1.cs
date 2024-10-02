using Algorithms.VacuumCleaner;

namespace Tests.VacuumCleaner;

public class UnitTest1
{
    private readonly List<Command> _commands =
    [
        new(Direction.South, 4),
        new(Direction.East, 8),
        new(Direction.South, 5),
        new(Direction.West, 8),
        new(Direction.North, 1),
        new(Direction.East, 4),
        new(Direction.North, 6),
        new(Direction.East, 2),
        new(Direction.South, 8),
        new(Direction.West, 2),
        new(Direction.North, 4),
        new(Direction.East, 6),
        new(Direction.North, 5),
    ];

    [Fact]
    public void Should_create_lines_from_commands()
    {
        // arrange

        // act
        var lines = Robot.CreateLines(0, 10, _commands);

        // assert
        lines.Should().HaveCount(13);
    }

    public static IEnumerable<object[]> CrossingLines() =>
    [
        // perpendicular lines
        [
            new Line(0, 2, 4, 2),
            new Line(2, 0, 2, 4),
            true
        ],
        [
            new Line(0, 2, 4, 2),
            new Line(2, 4, 2, 0),
            true
        ],
        [
            new Line(4, 2, 0, 2),
            new Line(2, 0, 2, 4),
            true
        ],
        [
            new Line(4, 2, 0, 2),
            new Line(2, 4, 2, 0),
            true
        ],
        [
            new Line(0, 2, 4, 2),
            new Line(2, 1, 2, 0),
            false
        ],
        [
            new Line(2, 4, 2, 0),
            new Line(0, 2, 1, 2),
            false
        ],
        [
            new Line(2, 4, 2, 0),
            new Line(3, 2, 4, 2),
            false
        ],
        [
            new Line(0, 2, 1, 2),
            new Line(2, 4, 2, 3),
            false
        ],
        // overlapping lines (horizontal)
        [
            new Line(0, 2, 5, 2),
            new Line(3, 2, 10, 2),
            true
        ],
        [
            new Line(0, 2, 10, 2),
            new Line(3, 2, 5, 2),
            true
        ],
        [
            new Line(3, 2, 5, 2),
            new Line(0, 2, 10, 2),
            true
        ],
        [
            new Line(3, 2, 10, 2),
            new Line(0, 2, 5, 2),
            true
        ],
        [
            new Line(0, 2, 3, 2),
            new Line(5, 2, 10, 2),
            false
        ],
        [
            new Line(5, 2, 10, 2),
            new Line(0, 2, 3, 2),
            false
        ],
        // overlapping lines (vertical)
        [
            new Line(2, 0, 2, 5),
            new Line(2, 3, 2, 10),
            true
        ],
        [
            new Line(2, 0, 2, 10),
            new Line(2, 3, 2, 5),
            true
        ],
        [
            new Line(2, 3, 2, 5),
            new Line(2, 0, 2, 10),
            true
        ],
        [
            new Line(2, 3, 2, 10),
            new Line(2, 0, 2, 5),
            true
        ],
        [
            new Line(2, 0, 2, 3),
            new Line(2, 5, 2, 10),
            false
        ],
        [
            new Line(2, 5, 2, 10),
            new Line(2, 0, 2, 3),
            false
        ],
    ];

    public static IEnumerable<object[]> CommonPoints() =>
    [
        [
            new Line(0, 2, 4, 2),
            new Line(2, 0, 2, 4),
            1
        ],
        [
            new Line(0, 2, 4, 2),
            new Line(2, 4, 2, 0),
            1
        ],
        [
            new Line(4, 2, 0, 2),
            new Line(2, 0, 2, 4),
            1
        ],
        [
            new Line(4, 2, 0, 2),
            new Line(2, 4, 2, 0),
            1
        ],
        [
            new Line(0, 2, 4, 2),
            new Line(2, 1, 2, 0),
            0
        ],
        [
            new Line(2, 4, 2, 0),
            new Line(0, 2, 1, 2),
            0
        ],
        [
            new Line(2, 4, 2, 0),
            new Line(3, 2, 4, 2),
            0
        ],
        [
            new Line(0, 2, 1, 2),
            new Line(2, 4, 2, 3),
            0
        ],
        // overlapping lines (horizontal)
        [
            new Line(0, 2, 5, 2),
            new Line(3, 2, 10, 2),
            3
        ],
        [
            new Line(0, 2, 10, 2),
            new Line(3, 2, 5, 2),
            3
        ],
        [
            new Line(3, 2, 5, 2),
            new Line(0, 2, 10, 2),
            3
        ],
        [
            new Line(3, 2, 10, 2),
            new Line(0, 2, 5, 2),
            3
        ],
        [
            new Line(0, 2, 3, 2),
            new Line(5, 2, 10, 2),
            0
        ],
        [
            new Line(5, 2, 10, 2),
            new Line(0, 2, 3, 2),
            0
        ],
        // overlapping lines (vertical)
        [
            new Line(2, 0, 2, 5),
            new Line(2, 3, 2, 10),
            3
        ],
        [
            new Line(2, 0, 2, 10),
            new Line(2, 3, 2, 5),
            3
        ],
        [
            new Line(2, 3, 2, 5),
            new Line(2, 0, 2, 10),
            3
        ],
        [
            new Line(2, 3, 2, 10),
            new Line(2, 0, 2, 5),
            3
        ],
        [
            new Line(2, 0, 2, 3),
            new Line(2, 5, 2, 10),
            0
        ],
        [
            new Line(2, 5, 2, 10),
            new Line(2, 0, 2, 3),
            0
        ],
    ];

    [Theory]
    [MemberData(nameof(CrossingLines))]
    public void Should_find_crossing_lines(Line a, Line b, bool expected)
    {
        // arrange

        // act
        var result = a.Intersects(b);

        // assert
        result.Should().Be(expected);
    }

    [Theory]
    [MemberData(nameof(CommonPoints))]
    public void Should_find_common_points(Line a, Line b, int expected)
    {
        // arrange

        // act
        var result = a.GetCommonPoints(b);

        // assert
        result.Should().Be(expected);
    }

    public static IEnumerable<object[]> UniquePlaces() =>
    [
        [
            new List<Command>
            {
                new(Direction.North, 3),
                new(Direction.South, 3),
                new(Direction.North, 3),
            },
            4
        ],
        [
            new List<Command>
            {
                new(Direction.North, 4),
                new(Direction.East, 4),
                new(Direction.South, 4),
                new(Direction.West, 4),
            },
            16
        ]
    ];

    [Theory]
    [MemberData(nameof(UniquePlaces))]
    public void Should_calculate_unique_places(List<Command> commands, int expected)
    {
        // arrange
        var lines = Robot.CreateLines(0, 0, commands);

        // act
        var uniquePlaces = Robot.CountUniquePlaces(lines.ToList());

        // assert
        uniquePlaces.Should().Be(expected);
    }

    public static IEnumerable<object[]> MergingHorizontalLines() =>
    [
        [
            new Line(0, 0, 5, 0),
            new Line(3, 0, 10, 0),
            0,
            10
        ],
        [
            new Line(3, 0, 10, 0),
            new Line(0, 0, 5, 0),
            0,
            10
        ],
        [
            new Line(10, 0, 3, 0),
            new Line(0, 0, 5, 0),
            0,
            10
        ],
        [
            new Line(10, 0, 3, 0),
            new Line(5, 0, 0, 0),
            0,
            10
        ],
    ];

    [Theory]
    [MemberData(nameof(MergingHorizontalLines))]
    public void Should_merge_horizontal_lines(Line a, Line b, int expectedStartX, int expectedEndX)
    {
        // arrange

        // act
        var result = Line.Merge(a, b);

        // assert
        result.Start.X.Should().Be(expectedStartX);
        result.End.X.Should().Be(expectedEndX);
    }

    public static IEnumerable<object[]> MergingVerticalLines() =>
    [
        [
            new Line(0, 3, 0, 10),
            new Line(0, 0, 0, 5),
            0,
            10
        ],
        [
            new Line(0, 0, 0, 5),
            new Line(0, 3, 0, 10),
            0,
            10
        ],
        [
            new Line(0, 10, 0, 3),
            new Line(0, 0, 0, 5),
            0,
            10
        ],
        [
            new Line(0, 3, 0, 10),
            new Line(0, 5, 0, 0),
            0,
            10
        ],
    ];

    [Theory]
    [MemberData(nameof(MergingVerticalLines))]
    public void Should_merge_vertical_lines(Line a, Line b, int expectedStartY, int expectedEndY)
    {
        // arrange

        // act
        var result = Line.Merge(a, b);

        // assert
        result.Start.Y.Should().Be(expectedStartY);
        result.End.Y.Should().Be(expectedEndY);
    }
}
