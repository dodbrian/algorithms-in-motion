using Algorithms.Hashing;
using FluentAssertions;

namespace Tests.Hashing;

public class UniqueNumbersInArrayTests
{
    [Fact]
    public void Should_return_unique_numbers_in_array()
    {
        // arrange
        var numsForUnique = new[] { 1, 3, 6, 9, 11, 12, 13, 15 };
        var expected = new[] { 1, 3, 6, 9, 15 };

        // act
        var ints = UniqueNumbersInArray.Calculate(numsForUnique);

        // assert
        ints.Should().BeEquivalentTo(expected, because: "The test is not finished yet");
    }
}
