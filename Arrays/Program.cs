using Arrays;

Console.WriteLine("Sorted and Combined");

var arr1 = new[] { 1, 3, 7, 11, 15, 23, 116 };
var arr2 = new[] { 1, 4, 5, 18, 25, 43, 116, 124, 221 };

var result = SortedAndCombined.Combine2(arr1, arr2);

foreach (var i in result)
{
    Console.Write($"{i} ");
    Console.WriteLine();
}

Console.WriteLine("Longest Sub Array Sum");

var nums = new[] { 3, 1, 2, 7, 4, 2, 1, 1, 5 };
var longest1 = LongestSubArraySum.Calculate(arr2, 80);
var longest2 = LongestSubArraySum.Calculate(nums, 8);

Console.WriteLine(longest1);
Console.WriteLine(longest2);

Console.WriteLine("Longest Substring Of Ones");

const string s = "01101100111";

var longestOfOnes = LongestSubstringOfOnes.Calculate(s);

Console.WriteLine(longestOfOnes);

Console.WriteLine("Largest Sub Array Sum");

var fixedWindowArray = new[] { 3, -1, 4, 12, -8, 5, 6 };

var subArraySum = LargestFixedSubArraySum.Calculate(fixedWindowArray, 4);

Console.WriteLine(subArraySum);
