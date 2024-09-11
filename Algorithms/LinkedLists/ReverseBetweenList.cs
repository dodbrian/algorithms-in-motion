using Algorithms.DataStructures;

namespace Algorithms.LinkedLists;

public static class ReverseBetweenList
{
    public static ListNode ReverseBetween(ListNode head, int left, int right)
    {
        var prev = left == 1 ? null : head;
        for (var i = 1; i < left - 1; i++)
            prev = prev.Next;

        var start = prev?.Next ?? head;
        var end = start;
        for (var i = left; i < right; i++)
            end = end.Next;

        var post = end.Next;
        end.Next = null;
        Reverse(start);

        if (prev is null) head = end;
        else prev.Next = end;

        start.Next = post;

        return head;
    }

    private static ListNode Reverse(ListNode head)
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
