using Algorithms.ArraysAndStrings;
using FluentAssertions;

namespace Tests.ArraysAndStrings;

public class LongestSubstringOfOnesTests
{
    [Fact]
    public void Should_return_longest_substring_of_ones()
    {
        // arrange
        const string s = "01101100111";

        // act
        var longestOfOnes = LongestSubstringOfOnes.Calculate(s);

        // assert
        longestOfOnes.Should().Be(3);
    }
}
