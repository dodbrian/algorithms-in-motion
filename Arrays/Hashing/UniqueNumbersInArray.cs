// Given an integer array nums, find all the unique numbers x in nums that satisfy the following:
// x + 1 is not in nums, and x - 1 is not in nums.

namespace Arrays.Hashing;

public static class UniqueNumbersInArray
{
    public static IEnumerable<int> Calculate(int[] nums) => FindNumbers(nums).ToHashSet();

    private static IEnumerable<int> FindNumbers(int[] nums)
    {
        var hash = nums.ToHashSet();

        foreach (var num in nums)
        {
            if (hash.Contains(num + 1) && hash.Contains(num - 1)) continue;

            yield return num;
        }
    }
}
