int? BinarySearch1(int[] sortedArray, int number)
{
    var low = 0;
    var high = sortedArray.Length - 1;

    while (true)
    {
        var mid = (high - low + 1) / 2 + low;
        var midValue = sortedArray[mid];

        if (midValue == number) return mid;
        if (low == high) return null;

        if (midValue > number) high = mid - 1;
        else low = mid;
    }
}

int? BinarySearch2(int[] sortedArray, int number)
{
    var low = 0;
    var high = sortedArray.Length - 1;

    while (low <= high)
    {
        var mid = low + (high - low) / 2;
        var midValue = sortedArray[mid];

        if (midValue == number)
            return mid;

        if (midValue > number)
            high = mid - 1;
        else
            low = mid + 1;
    }

    return null;
}

var numbers = new[] { 1, 12, 35, 42, 58 };
var numbersToLookFor = new[] { 0, 1, 5, 12, 23, 35, 39, 42, 51, 58, 63 };

Console.WriteLine("Version 1:");
numbersToLookFor
    .Select(number => (Number: number, Position: BinarySearch1(numbers, number)))
    .ToList()
    .ForEach(tuple => Console.WriteLine($"Number {tuple.Number} at position {tuple.Position}"));

Console.WriteLine("Version 2:");
numbersToLookFor
    .Select(number => (Number: number, Position: BinarySearch2(numbers, number)))
    .ToList()
    .ForEach(tuple => Console.WriteLine($"Number {tuple.Number} at position {tuple.Position}"));
