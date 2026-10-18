namespace Adv_Assignment_01;

internal class Container<T> where T : new()
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
