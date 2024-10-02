using Algorithms.Graphs;

namespace Tests.Graphs;

public class NumberOfProvincesTests
{
    public static IEnumerable<object[]> NumberOfProvincesData =
    [
        [
            new int[][]
            {
                [1, 1, 0],
                [1, 1, 0],
                [0, 0, 1]
            },
            2
        ],
        [
            new int[][]
            {
                [1, 0, 0],
                [0, 1, 0],
                [0, 0, 1]
            },
            3
        ],
        [
            new int[][]
            {
                [0, 1, 0, 0, 0, 0],
                [0, 0, 0, 1, 0, 0],
                [0, 0, 0, 1, 0, 0],
                [0, 0, 0, 0, 0, 0],
                [1, 0, 0, 0, 0, 1],
                [0, 0, 0, 0, 0, 0],
            },
            1
        ],
    ];

    [Theory]
    [MemberData(nameof(NumberOfProvincesData))]
    public void Should_get_number_of_provinces(int[][] graph, int expected)
    {
        // arrange
        var provinces = new NumberOfProvinces();

        // act
        var result = provinces.GetNumberOfProvinces(graph);

        // assert
        result.Should().Be(expected);
    }
}
