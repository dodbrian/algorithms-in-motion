using Algorithms.DataStructures;
using Algorithms.LinkedLists;
using FluentAssertions;

namespace Tests.LinkedLists;

public class ReverseListTests
{
    private static readonly int[] Expectation = [7, 5, 3, 1];

    [Fact]
    public void Should_reverse_list()
    {
        // arrange
        const int len = 7; // must be odd
        var head = new ListNode(1);
        var curr = head;

        for (var i = 2; i < len + 2; i++)
        {
            curr.Next = new ListNode(i);
            curr = curr.Next;
        }

        // act
        var listNode = ReverseList.Reverse(head);

        // assert
        listNode.Should().BeEquivalentTo(Expectation);
    }
}
