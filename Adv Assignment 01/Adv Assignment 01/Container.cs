namespace Adv_Assignment_01;

internal class Container<T> where T : IEquatable<T>
{
    private T item;

    public void Add(T value)
    {
        item = value;
    }

    public T Get()
    {
        return item;
    }
}
