using Algorithms.Hashing;
using FluentAssertions;

namespace Tests.Hashing;

public class UniqueNumbersInArrayTests
{
    [Fact]
    public void Should_return_unique_numbers_in_array()
    {
        // arrange
        var numsForUnique = new[] { 1, 2, 3, 4, 3, 2, 1, 5, 6, 8, 9, 11, 12 };

        // act
        var ints = UniqueNumbersInArray.Calculate(numsForUnique);

        // assert
        false.Should().BeTrue(because: "The test is not finished yet");
        foreach (var num in ints) Console.WriteLine(num);
    }
}
