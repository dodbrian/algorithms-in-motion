using Algorithms.ArraysAndStrings;
using FluentAssertions;

namespace Tests.ArraysAndStrings;

public class LongestSubArraySumTests
{
    public static TheoryData<int[], int, int> LongestSubArraySumData =>
        new()
        {
            { [3, 1, 2, 7, 4, 2, 1, 1, 5], 8, 4 },
            { [1, 4, 5, 18, 25, 43, 116, 124, 221], 80, 5 }
        };

    [Theory]
    [MemberData(nameof(LongestSubArraySumData))]
    public void Should_return_longest_subarray_sum(int[] arr, int k, int expected)
    {
        // arrange

        // act
        var longest2 = LongestSubArraySum.Calculate(arr, k);

        // assert
        longest2.Should().Be(expected);
    }
}
