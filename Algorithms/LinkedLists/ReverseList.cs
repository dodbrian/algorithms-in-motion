using Algorithms.DataStructures;

namespace Algorithms.LinkedLists;

public static class ReverseList
{
    /// <summary>
    /// Reverses a singly linked list.
    /// </summary>
    /// <param name="head">The head of the linked list to be reversed.</param>
    /// <returns>The head of the reversed linked list.</returns>
    public static ListNode Reverse(ListNode head)
    {
        var curr = head;
        ListNode prev = null;

        while (curr is not null)
        {
            var next = curr.Next;
            curr.Next = prev;
            prev = curr;
            curr = next;
        }

        return prev;
    }
}
