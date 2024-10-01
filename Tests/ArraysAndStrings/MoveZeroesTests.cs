using Algorithms.ArraysAndStrings;
using FluentAssertions;

namespace Tests.ArraysAndStrings;

public class MoveZeroesTests
{
    [Fact]
    public void Should_move_zeroes()
    {
        // arrange
        int[] numsWithZeroes = [1, 0, 0, 3, 6, 0, 12];
        int[] expected = [1, 3, 6, 12, 0, 0, 0];

        // act
        MoveZeroes.Calculate(numsWithZeroes);

        // assert
        numsWithZeroes.Should().BeEquivalentTo(expected);
    }
}
