namespace Algorithms.DataStructures;

public static class ListNodeExtensions
{
    /// <summary>
    /// Converts a linked list to an enumerable sequence of integers.
    /// </summary>
    /// <param name="head">The head of the linked list.</param>
    /// <returns>An enumerable sequence of integers representing the linked list.</returns>
    public static IEnumerable<int> ToEnumerable(this ListNode head)
    {
        var current = head;

        while (current != null)
        {
            yield return current.Value;

            current = current.Next;
        }
    }
}
