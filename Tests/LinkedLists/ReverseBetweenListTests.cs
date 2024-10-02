using Algorithms.DataStructures;
using Algorithms.LinkedLists;

namespace Tests.LinkedLists;

public class ReverseBetweenListTests
{
    private static readonly int[] Expectation = [1, 4, 3, 2, 5, 6, 7, 8];

    [Fact]
    public void Should_reverse_between_list()
    {
        // arrange
        const int len = 7; // must be odd
        var head = new ListNode(1);
        var curr = head;
        for (var i = 2; i < len + 2; i++)
        {
            curr.Next = new(i);
            curr = curr.Next;
        }

        // act
        var listNode = ReverseBetweenList.ReverseBetween(head, 2, 4);

        // assert
        listNode.ToEnumerable().Should().BeEquivalentTo(Expectation);
    }
}
