// Given the head of a linked list with an odd number of nodes head, return the value of the node
// in the middle.
// For example, given a linked list that represents 1 -> 2 -> 3 -> 4 -> 5, return 3.

using Algorithms.DataStructures;

namespace Algorithms.LinkedLists;

public static class MiddleNode
{
    public static int GetMiddle(ListNode head)
    {
        var fast = head;
        var slow = head;

        while (fast.Next is { Next: not null })
        {
            slow = slow.Next;
            fast = fast.Next.Next;
        }

        return slow.Value;
    }
}
