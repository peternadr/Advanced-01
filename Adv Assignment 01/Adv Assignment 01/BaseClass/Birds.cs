namespace Adv_Assignment_01.BaseClass;

internal class Birds<T> where T : FlyingBird
{
    public void Flying(T flyingBird)
    {
        flyingBird.Fly();
    }
}
