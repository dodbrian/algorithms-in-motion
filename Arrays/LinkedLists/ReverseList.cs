namespace Arrays.LinkedLists;

public static class ReverseList
{
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
