using Algorithms.DataStructures;
using Algorithms.LinkedLists;

namespace Tests.LinkedLists;

public class SwapPairsTests
{
    private static readonly int[] Expectation = [2, 1, 4, 3, 6, 5, 8, 7];

    [Fact]
    public void Should_swap_pairs()
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
        var listNode = SwapNodes.SwapPairs(head);

        // assert
        listNode.ToEnumerable().Should().BeEquivalentTo(Expectation);
    }
}
