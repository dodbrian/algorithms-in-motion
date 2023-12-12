using Arrays;

Console.WriteLine("Test Sorted and Combined");

var arr1 = new[] { 1, 3, 7, 11, 15, 23, 116 };
var arr2 = new[] { 1, 4, 5, 18, 25, 43, 116, 124, 221 };

var result = SortedAndCombined.Combine2(arr1, arr2);

foreach (var i in result)
{
    Console.Write($"{i} ");
    Console.WriteLine();
}

Console.WriteLine("Test Longest Sub Array Sum");

var longest = LongestSubArraySum.Calculate(arr2, 80);

Console.WriteLine(longest);
