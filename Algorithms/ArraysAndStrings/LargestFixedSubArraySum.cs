// Given an integer array nums and an integer k, find the sum of the subarray with the largest sum
// whose length is k.

namespace Algorithms.ArraysAndStrings;

public static class LargestFixedSubArraySum
{
    /// <summary>
    /// Finds the sum of the subarray with the largest sum whose length is k.
    /// </summary>
    /// <param name="nums">The input integer array.</param>
    /// <param name="k">The length of the subarray.</param>
    /// <returns>The sum of the subarray with the largest sum whose length is k.</returns>
    public static int Calculate(int[] nums, int k)
    {
        if (k < 1) return 0;

        var curr = 0;

        // build fixed subarray
        for (var i = 0; i < k; i++) curr += nums[i];

        var ans = curr;

        for (var i = k; i < nums.Length; i++)
        {
            curr = curr + nums[i] - nums[i - k];
            ans = Math.Max(curr, ans);
        }

        return ans;
    }
}
