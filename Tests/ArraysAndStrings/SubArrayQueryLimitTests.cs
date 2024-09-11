using Algorithms.ArraysAndStrings;
using FluentAssertions;

namespace Tests.ArraysAndStrings;

public class SubArrayQueryLimitTests
{
    [Fact]
    public void Should_check_subarray_sums_within_limit()
    {
        // arrange
        var arrayForSum = new[] { 2, 8, 16, 32, 4, 1, 23, 11, 9, 28 };
        var queries = new[] { [1, 8], [2, 3], [0, 9], new[] { 5, 7 } };
        const int limit = 123;

        // act
        var limitResults = CheckSubarraySumsWithinLimit.Calculate(arrayForSum, queries, limit);

        // assert
        limitResults.Should().BeEmpty(because: "The test is not finished yet");

        foreach (var (query, isWithinLimit) in queries.Zip(limitResults))
            Console.WriteLine($"{query[0]}, {query[1]}, {isWithinLimit}");
    }
}
