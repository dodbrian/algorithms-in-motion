using Algorithms;
using FluentAssertions;

namespace Tests;

public class SumOfDigitsTests
{
    [Theory]
    [InlineData(128, 11)]
    [InlineData(1, 1)]
    public void Should_return_sum_of_digits(int input, int expected)
    {
        // arrange

        // act
        var result = SumOfDigits.Calculate(input);

        // assert
        result.Should().Be(expected);
    }
}
