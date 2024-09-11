// Given two sorted integer arrays arr1 and arr2, return a new array that combines
// both of them and is also sorted.

namespace Algorithms.ArraysAndStrings;

public static class SortedAndCombined
{
    public static List<int> Combine(int[] arr1, int[] arr2)
    {
        var i = 0;
        var j = 0;
        var totalLength = arr1.Length + arr2.Length;
        var resultArray = new List<int>(totalLength);

        while (i + j < totalLength)
        {
            var val1 = i < arr1.Length ? arr1[i] : 0;
            var val2 = j < arr2.Length ? arr2[j] : 0;
            if (i < arr1.Length && val1 < val2)
            {
                resultArray.Add(val1);
                i++;
            }
            else
            {
                resultArray.Add(val2);
                j++;
            }
        }

        return resultArray;
    }

    public static List<int> Combine2(int[] arr1, int[] arr2)
    {
        int i = 0, j = 0;
        var resultArray = new List<int>(arr1.Length + arr2.Length);

        while (i < arr1.Length && j < arr2.Length)
            resultArray.Add(arr1[i] < arr2[j] ? arr1[i++] : arr2[j++]);

        while (i < arr1.Length) resultArray.Add(arr1[i++]);
        while (j < arr2.Length) resultArray.Add(arr2[j++]);

        return resultArray;
    }
}
