using Algorithms.ArraysAndStrings;
using FluentAssertions;

namespace Tests.ArraysAndStrings;

public class SubArrayQueryLimitTests
{
    [Fact]
    public void Should_check_subarray_sums_within_limit()
    {
        // arrange
        int[] arrayForSum = [2, 8, 16, 32, 4, 1, 23, 11, 9, 28];
        int[][] queries = [[1, 8], [2, 3], [0, 9], [5, 7]];
        bool[] expected = [true, true, false, true];
        const int limit = 123;

        // act
        var limitResults = CheckSubarraySumsWithinLimit.Calculate(arrayForSum, queries, limit);

        // assert
        limitResults.Should().BeEquivalentTo(expected);
    }
}
