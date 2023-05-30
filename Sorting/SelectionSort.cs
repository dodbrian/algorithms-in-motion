namespace Sorting;

public static class SelectionSort
{
    public static int FindSmallest(IList<int> array)
    {
        var smallest = array[0];
        var smallestIndex = 0;

        for (var i = 1; i < array.Count; i++)
            if (array[i] < smallest)
            {
                smallest = array[i];
                smallestIndex = i;
            }

        return smallestIndex;
    }

    public static List<int> Sort(int[] array)
    {
        var sourceList = array.ToList();
        var newList = new List<int>(array.Length);

        while (sourceList.Any())
        {
            var minIndex = FindSmallest(sourceList);
            newList.Add(sourceList[minIndex]);
            sourceList.RemoveAt(minIndex);
        }

        return newList;
    }
}
