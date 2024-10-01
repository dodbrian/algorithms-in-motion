using Algorithms.ArraysAndStrings;
using FluentAssertions;

namespace Tests.ArraysAndStrings;

public class MinimumStartValueTests
{
    [Fact]
    public void Should_return_minimum_start_value()
    {
        // arrange
        var valNums = new[] { -3, 2, -3, 4, 2 };

        // act
        var minVal = MinStartValue.Calculate(valNums);

        // assert
        minVal.Should().Be(5);
    }
}
