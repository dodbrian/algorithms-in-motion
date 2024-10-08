using Algorithms.DataStructures;

namespace Algorithms.LinkedLists;

public static class SwapNodes
{
    public static ListNode SwapPairs(ListNode head)
    {
        if (head?.Next is null) return head;

        var left = head;
        var right = head.Next;
        head = right;

        while (right is not null)
        {
            left.Next = right.Next?.Next;
            var temp = right.Next;
            right.Next = left;
            right = left.Next;
            left = temp;
        }

        return head;
    }
}
