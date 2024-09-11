using Algorithms.DataStructures;
using Algorithms.LinkedLists;
using FluentAssertions;

namespace Tests.LinkedLists;

public class KthNodeFromTheEndTests
{
    [Fact]
    public void Should_return_kth_node_from_the_end()
    {
        // arrange
        const int len = 7; // must be odd
        var head = new ListNode(1);
        var curr = head;

        for (var i = 2; i < len + 1; i++)
        {
            curr.Next = new(i);
            curr = curr.Next;
        }

        // act
        var node = KthNodeFromEnd.GetNode(head, 3);

        // assert
        node.Should().Be(400);
    }
}
