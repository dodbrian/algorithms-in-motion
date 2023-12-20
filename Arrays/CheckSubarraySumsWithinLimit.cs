// Given an integer array nums, an array queries where queries[i] = [x, y] and an integer limit,
// return a boolean array that represents the answer to each query.
// A query is true if the sum of the subarray from x to y is less than limit, or false otherwise.

namespace Arrays;

public static class CheckSubarraySumsWithinLimit
{
    public static bool[] Calculate(int[] nums, int[][] queries, int limit)
    {
        if (nums.Length == 0 || queries.Length == 0) return Array.Empty<bool>();

        var prefixSum = new int[nums.Length];

        prefixSum[0] = nums[0];

        for (var i = 1; i < nums.Length; i++)
            prefixSum[i] = prefixSum[i - 1] + nums[i];

        var results = new bool[queries.Length];

        for (var i = 0; i < queries.Length; i++)
        {
            var x = queries[i][0];
            var y = queries[i][1];

            results[i] = prefixSum[y] - prefixSum[x] + nums[x] < limit;
        }

        return results;
    }
}
