using Adv_Assignment_01.BaseClass;

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

        //Container<int> container = new Container<int>();
        //container.Add(10);
        //Console.WriteLine(container.Get()); 

        //Container<string> container1 = new Container<string>();
        //container1.Add("peter");     
        //Console.WriteLine(container1.Get());


        #endregion

        #region Q03
        //Q3:What are multiple type parameters? Write Pair<TKey, TValue>.
        // A multitype parameter means a generic class or method can accept more than one type parameter

        //Pair<int, string> pair = new Pair<int, string>(20, "peter");

        #endregion

        #region Q04
        //Q4: What is a generic method? Write Swap<T> method.

        //int A = 20, B = 10;
        //Swap<int>(ref A, ref B);
        //Console.WriteLine(A);
        //Console.WriteLine(B);
        #endregion

        #region Q05
        //Q5: Write a generic method FindMax<T> that finds maximum value
        //string[] arr = { "ali"  ,"peter", "omer"};
        //Console.WriteLine(FindMax<string>(arr));

        #endregion

        #region Q06
        //Q6: What is a generic interface? Write IRepository<T>. 
        //A generic interface is a interface that uses a type parameter, allowing it to work with different data types.

        //IRepository<int> repository;
        #endregion

        #region Q07
        //Q7: What is the 'struct' constraint? Write an example.
        //The struct constraint in C# generics ensures that the type argument must be a non-nullable value type

        //Container<int> c1 = new Container<int>();       // Valid
        //Container<double> c2 = new Container<double>(); // Valid
        // Container<string> c3 = new Container<string>(); // Error
        #endregion

        #region Q08
        //Q8: What is the 'class' constraint? Write an example.
        //The cladd constraint in C# generics ensures that the type argument must be a reference type

        //Container<string> c3 = new Container<string>(); // valid
        //Container<int[]> c2 = new Container<int[]>(); // Valid
        //Container<int> c1 = new Container<int>(); // Error
        #endregion

        #region Q09
        //Q9: What is the 'new()' constraint? Write an example.
        //The new() constraint in C# generics ensures that the type parameter has a public parameterless constructor


        //Container<Pair<int, int>> container;
        #endregion

        #region Q10
        //Q10:  What is the interface constraint? Write an example.
        //A interface constraint in C# generics ensures that the type parameter T implements a specific interface

        //Container<int> container; // valid
        //Container<int[]> container1; // error
        #endregion

        #region Q11
        //Q11: What is the base class constraint? Write an example.
        // A base class constraint in C# generics ensures that the type parameter T must be the specified base class or a class derived from it

        //Birds<Eagle> eagle; // valid
        //Birds<Pingouin> pingouin; // error
        #endregion

        #region Q12
        //Q12: How do you apply multiple constraints? Write an example. 
        //we can apply multiple constraints to a generic type parameter using the where keyword followed by the required constraints




        #endregion

        #region Q13
        //Q13: What does the 'default' keyword do in generics?
        // default keyword in generics returns the defualt value of a type



        #endregion

        #region Q14
        //Q14: Write a SafeList<T> that returns default when the index is invalid.
        int[] items = { 1, 12 , 5};
        Console.WriteLine(GetSafeList(items, 1));
        Console.WriteLine(GetSafeList(items, 3));
        #endregion

    }

    public static void Swap<T>(ref T A, ref T B)
    {
        T temp = A;
        A = B;
        B = temp;
    }

    public static T FindMax<T>(T[] arr) where T : IComparable<T>
    {
        T max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i].CompareTo(max) > 0)
            {
                max = arr[i];
            }
        }
        return max;
    }

    public static T GetSafeList<T>(T[] items, int index)
    {
        if (index < 0 || index >= items.Length)
        {
            return default;
        }
        return items[index];
    }
}