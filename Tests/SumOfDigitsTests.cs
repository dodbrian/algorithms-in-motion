using Algorithms;
using FluentAssertions;

namespace Tests;

public class SumOfDigitsTests
{
    [Theory]
    [InlineData(128, 500)]
    [InlineData(1, 500)]
    public void Should_return_sum_of_digits(int input, int expected)
    {
        // arrange

        // act
        var result = SumOfDigits.Calculate(input);

        // assert
        result.Should().Be(expected);
    }
}
