// You are given a string s and an integer k. Find the length of the longest substring that contains
// at most k distinct characters.
// For example, given s = "eceba" and k = 2, return 3. The longest substring with at most 2 distinct
// characters is "ece".

namespace Algorithms.Hashing;

public static class LongestDistinctSubstring
{
    public static int Calculate(string s, int k)
    {
        var left = 0;
        var ans = 0;
        var map = new Dictionary<char, int>();

        for (var i = 0; i < s.Length; i++)
        {
            Add(map, s[i]);

            while (map.Keys.Count > k)
            {
                Remove(map, s[left]);
                left++;
            }

            var len = i - left + 1;
            ans = len > ans ? len : ans;
        }

        return ans;
    }

    private static void Add(IDictionary<char, int> map, char c)
    {
        if (map.TryGetValue(c, out var count))
            map[c] = count + 1;
        else
            map[c] = 1;
    }

    private static void Remove(IDictionary<char, int> map, char c)
    {
        if (!map.TryGetValue(c, out var count)) return;

        if (count > 1)
            map[c] = count - 1;
        else
            map.Remove(c);
    }
}
