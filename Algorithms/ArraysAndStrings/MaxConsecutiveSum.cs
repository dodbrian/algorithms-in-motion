// Implement a function that calculates the max consecutive sum on a subsequence of integers. What is the maximum sum
// one can achieve by summing consecutive numbers on a finite array of positive and negative numbers? One can start
// and end anywhere, but it is not allowed to skip numbers.
// For example, consider the array [2, -4, 2, -1, 3, -3, 10, -1, -11, -100, 8, -1].
// The max possible consecutive sum is 11 (starting from the index 2 and ending with the index 6, both zero-based).
// Don't focus on algorithmic optimization. Any non-exponential time complexity is sufficient.

namespace Algorithms.ArraysAndStrings;

public static class MaxConsecutiveSum
{
    /// <summary>
    /// Finds the maximum consecutive sum of integers in the given array.
    /// </summary>
    /// <param name="numbers">The array of integers.</param>
    /// <returns>The maximum consecutive sum of integers in the array.</returns>
    public static int FindMaxConsecutiveSum(int[] numbers)
    {
        var max = numbers[0];
        var current = numbers[0];

        for (var i = 1; i < numbers.Length; i++)
        {
            current = Math.Max(numbers[i], current + numbers[i]);
            max = Math.Max(max, current);
        }

        return max;
    }
}
