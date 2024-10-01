using Algorithms.DataStructures;

namespace Algorithms.LinkedLists;

public static class KthNodeFromEnd
{
    /// <summary>
    /// Finds the kth node from the end in a singly linked list.
    /// </summary>
    /// <param name="head">The head of the linked list.</param>
    /// <param name="k">The position of the node to look for, where 1 is the last node.</param>
    /// <returns>The kth node from the end, or null if no such node exists.</returns>
    public static ListNode GetNode(ListNode head, int k)
    {
        var first = head;
        var second = head;

        for (var i = 1; i < k; i++)
        {
            if (second.Next is null) return null;
            second = second.Next;
        }

        while (second.Next is not null)
        {
            first = first.Next;
            second = second.Next;
        }

        return first;
    }
}
