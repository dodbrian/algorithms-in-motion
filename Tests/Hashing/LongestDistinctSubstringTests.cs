using Algorithms.Hashing;

namespace Tests.Hashing;

public class LongestDistinctSubstringTests
{
    [Fact]
    public void Should_return_longest_distinct_substring()
    {
        // arrange
        const string line = "ecebdeeeeee";

        // act
        var longest = LongestDistinctSubstring.Calculate(line, 3);

        // assert
        longest.Should().Be(9);
    }
}
