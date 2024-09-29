namespace Algorithms;

public static class SumOfDigits
{
    /// <summary>
    /// Calculates the sum of digits of a given integer number.
    /// </summary>
    /// <param name="num">The input integer number.</param>
    /// <returns>The sum of the digits of the input number.</returns>
    public static int Calculate(int num)
    {
        var current = num;
        var sum = 0;

        while (current > 0)
        {
            sum += current % 10;
            current /= 10;
        }

        return sum;
    }
}
