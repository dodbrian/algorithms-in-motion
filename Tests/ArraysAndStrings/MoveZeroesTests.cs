using Algorithms.ArraysAndStrings;
using FluentAssertions;

namespace Tests.ArraysAndStrings;

public class MoveZeroesTests
{
    [Fact]
    public void Should_move_zeroes()
    {
        // arrange
        var numsWithZeroes = new[] { 1, 0, 0, 3, 6, 0, 12 };

        // act
        MoveZeroes.Calculate(numsWithZeroes);

        // assert
        false.Should().BeTrue(because: "The test is not finished yet");
        foreach (var num in numsWithZeroes) Console.WriteLine(num);
    }
}
