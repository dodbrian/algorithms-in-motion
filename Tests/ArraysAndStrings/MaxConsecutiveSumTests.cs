using Algorithms.ArraysAndStrings;

namespace Tests.ArraysAndStrings;

public class MaxConsecutiveSumTests
{
    [Fact]
    public void Should_find_max_consecutive_sum()
    {
        // arrange
        int[] nums = [2, -4, 2, -1, 3, -3, 10, -1, -11, -100, 8, -1];

        // act
        var result = MaxConsecutiveSum.FindMaxConsecutiveSum(nums);

        // assert
        result.Should().Be(11);
    }
}
