using Algorithms.DataStructures;

namespace Algorithms.LinkedLists;

public static class KthNodeFromEnd
{
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
