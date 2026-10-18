namespace Adv_Assignment_01;

internal class Program
{
    static void Main(string[] args)
    {
        #region Q01
        //Q1: What is a generic class? Why use generics?
        /* A generic class is a class that uses a type parameter, allowing it to work with different data types ,
        To Write one class works with multiable data type.
        To Avoid creating separate classes for each data type.
        */
        #endregion

        #region Q02
        //Q2: Write a generic class Container<T> with Add and Get methods.

        Container<int> container = new Container<int>();
        container.Add(10);
        Console.WriteLine(container.Get()); 

        Container<string> container1 = new Container<string>();
        container1.Add("peter");     
        Console.WriteLine(container1.Get());


        #endregion
    }
}
