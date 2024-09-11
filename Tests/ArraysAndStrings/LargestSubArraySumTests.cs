using Algorithms.ArraysAndStrings;
using FluentAssertions;

namespace Tests.ArraysAndStrings;

public class LargestSubArraySumTests
{
    [Fact]
    public void Should_return_largest_subarray_sum()
    {
        // arrange
        var fixedWindowArray = new[] { 3, -1, 4, 12, -8, 5, 6 };

        // act
        var subArraySum = LargestFixedSubArraySum.Calculate(fixedWindowArray, 4);

        // assert
        subArraySum.Should().Be(12);
    }
}
