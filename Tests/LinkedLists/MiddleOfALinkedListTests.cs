using Algorithms.DataStructures;
using Algorithms.LinkedLists;
using FluentAssertions;

namespace Tests.LinkedLists;

public class MiddleOfALinkedListTests
{
    [Fact]
    public void Should_return_middle_of_linked_list()
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
        var middle = MiddleNode.GetMiddle(head);

        // assert
        middle.Should().Be(400);
    }
}
