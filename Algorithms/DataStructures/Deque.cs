namespace Algorithms.DataStructures;

public class Deque<T>
{
    private readonly LinkedList<T> _items = new();

    public int Count => _items.Count;
    public bool IsEmpty => _items.Count == 0;
    public void AddFront(T item) => _items.AddFirst(item);
    public void AddBack(T item) => _items.AddLast(item);
    public T PeekFront() => _items.First.Value;
    public T PeekBack() => _items.Last.Value;

    public T RemoveFront()
    {
        T item = _items.First.Value;
        _items.RemoveFirst();
        return item;
    }

    public T RemoveBack()
    {
        T item = _items.Last.Value;
        _items.RemoveLast();
        return item;
    }
}