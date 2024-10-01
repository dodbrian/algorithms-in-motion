// Given an array of integers nums, you start with an initial positive value startValue.
// In each iteration, you calculate the step by step sum of startValue plus elements in nums (from left to right).
// Return the minimum positive value of startValue such that the step by step sum is never less than 1.

namespace Algorithms.ArraysAndStrings;

public static class MinStartValue
{
    /// <summary>
    /// Return the minimum positive value of startValue such that the step by step sum is never less than 1.
    /// </summary>
    /// <param name="nums">The input array of integers.</param>
    /// <returns>The minimum positive startValue.</returns>
    public static int Calculate(int[] nums)
    {
        var min = nums[0];
        var runningSum = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            runningSum += nums[i];
            if (runningSum < min) min = runningSum;
        }

        return min > 0 ? 1 : 1 - min;
    }
}
