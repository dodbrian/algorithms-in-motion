using Arrays;
using Arrays.Hashing;
using Arrays.LinkedLists;

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

Console.WriteLine("Sub Array Query Limit");

var arrayForSum = new[] { 2, 8, 16, 32, 4, 1, 23, 11, 9, 28 };
var queries = new[] { new[] { 1, 8 }, new[] { 2, 3 }, new[] { 0, 9 }, new[] { 5, 7 } };
const int limit = 123;

var limitResults = CheckSubarraySumsWithinLimit.Calculate(arrayForSum, queries, limit);

foreach (var (query, isWithinLimit) in queries.Zip(limitResults))
    Console.WriteLine($"{query[0]}, {query[1]}, {isWithinLimit}");

Console.WriteLine("Minimum Start Value");

var valNums = new[] { -3, 2, -3, 4, 2 };
var minVal = MinStartValue.Calculate(valNums);

Console.WriteLine(minVal);

Console.WriteLine("Move Zeroes");

var numsWithZeroes = new[] { 1, 0, 0, 3, 6, 0, 12 };

MoveZeroes.Calculate(numsWithZeroes);

foreach (var num in numsWithZeroes) Console.WriteLine(num);

Console.WriteLine("Unique Numbers In Array");

var numsForUnique = new[] { 1, 2, 3, 4, 3, 2, 1, 5, 6, 8, 9, 11, 12 };
var ints = UniqueNumbersInArray.Calculate(numsForUnique);

foreach (var num in ints) Console.WriteLine(num);

Console.WriteLine("Longest Distinct Substring");

var longest = LongestDistinctSubstring.Calculate("ecebdeeeeee", 3);

Console.WriteLine(longest);

Console.WriteLine("Sum Of Digits");
Console.WriteLine(SumOfDigits.Calculate(128));
Console.WriteLine(SumOfDigits.Calculate(1));

Console.WriteLine("Middle Of A Linked List");

const int len = 5; // must be odd
var head = new ListNode(1);
var curr = head;
for (var i = 2; i < len + 1; i++)
{
    curr.Next = new ListNode(i);
    curr = curr.Next;
}

var middle = MiddleNode.GetMiddle(head);

Console.WriteLine(middle);
