using Sorting;

var array = new[] { 5, 12, 43, 16, 113, -1, 54 };
var smallestIndex = SelectionSort.FindSmallest(array);

Console.WriteLine($"Index of a smallest number is {smallestIndex}");

var sortedList = SelectionSort.Sort(array);

Console.WriteLine("Sorted list:");
sortedList.ForEach(number => Console.Write($"{number},"));
