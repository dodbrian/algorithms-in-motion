using Algorithms.ArraysAndStrings;

namespace Tests.ArraysAndStrings;

public class SortedAndCombinedTests
{
    private static readonly int[] Expected = [1, 1, 3, 4, 5, 7, 11, 15, 18, 23, 25, 43, 116, 116, 124, 221];

    [Fact]
    public void Should_return_sorted_and_combined()
    {
        // arrange
        var arr1 = new[] { 1, 3, 7, 11, 15, 23, 116 };
        var arr2 = new[] { 1, 4, 5, 18, 25, 43, 116, 124, 221 };

        // act
        var result = SortedAndCombined.Combine(arr1, arr2);

        // assert
        result.Should().BeEquivalentTo(Expected);
    }

    [Fact]
    public void Should_return_sorted_and_combined_2()
    {
        // arrange
        var arr1 = new[] { 1, 3, 7, 11, 15, 23, 116 };
        var arr2 = new[] { 1, 4, 5, 18, 25, 43, 116, 124, 221 };

        // act
        var result = SortedAndCombined.Combine2(arr1, arr2);

        // assert
        result.Should().BeEquivalentTo(Expected);
    }
}
