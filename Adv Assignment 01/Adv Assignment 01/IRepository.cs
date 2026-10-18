namespace Adv_Assignment_01;

internal interface IRepository<T>
{
    void Add(T value);
    T Get();
    
}
