namespace Algorithms;

public static class SumOfDigits
{
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
