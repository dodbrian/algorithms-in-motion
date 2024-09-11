// Given an array of positive integers nums and an integer k,
// find the length of the longest subarray whose sum is less than or equal to k.

namespace Algorithms.ArraysAndStrings;

public static class LongestSubArraySum
{
    public static int Calculate(int[] nums, int k)
    {
        var left = 0;
        var currentSum = 0;
        var longest = 0;

        for (var right = 0; right < nums.Length; right++)
        {
            currentSum += nums[right];
            while (currentSum > k && left < right) currentSum -= nums[left++];

            var length = right - left + 1;
            longest = longest < length ? length : longest;
        }

        return longest;
    }
}
