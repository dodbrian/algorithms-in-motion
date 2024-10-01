namespace Algorithms.ArraysAndStrings;

public static class MoveZeroes
{
    /// <summary>
    /// Moves all the zeroes of the given array to the right.
    /// </summary>
    /// <param name="nums">The input array of integers.</param>
    public static void Calculate(int[] nums)
    {
        var left = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0) continue;

            nums[left] = nums[i];
            if (left != i) nums[i] = 0;
            left++;
        }
    }
}
// 1, 0, 0, 3, 6, 0, 12
