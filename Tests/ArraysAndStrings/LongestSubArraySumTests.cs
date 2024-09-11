using Algorithms.ArraysAndStrings;
using FluentAssertions;

namespace Tests.ArraysAndStrings;

public class LongestSubArraySumTests
{
    [Fact]
    public void Should_return_longest_subarray_sum()
    {
        // arrange
        var nums = new[] { 3, 1, 2, 7, 4, 2, 1, 1, 5 };
        var arr2 = new[] { 1, 4, 5, 18, 25, 43, 116, 124, 221 };

        // act
        var longest1 = LongestSubArraySum.Calculate(arr2, 80);
        var longest2 = LongestSubArraySum.Calculate(nums, 8);

        // assert
        longest1.Should().Be(3);
        longest2.Should().Be(5);
    }
}
