// You are given a binary string s (a string containing only "0" and "1"). You may choose up to
// one "0" and flip it to a "1". What is the length of the longest substring achievable that contains only "1"?
//
// For example, given s = "1101100111", the answer is 5. If you perform the flip at index 2,
// the string becomes 1111100111.

namespace Algorithms.ArraysAndStrings;

public static class LongestSubstringOfOnes
{
    /// <summary>
    /// Calculates the length of the longest substring in the given string, which contains at most one '0'.
    /// </summary>
    /// <param name="s">The input string.</param>
    /// <returns>The length of the longest substring.</returns>
    public static int Calculate(string s)
    {
        var ans = 0;
        var left = 0;
        var numberOfZeroes = 0;

        for (var right = 0; right < s.Length; right++)
        {
            if (s[right] == '0') numberOfZeroes++;

            while (numberOfZeroes > 1)
                if (s[left++] == '0')
                    numberOfZeroes--;

            ans = Math.Max(ans, right - left + 1);
        }

        return ans;
    }
}