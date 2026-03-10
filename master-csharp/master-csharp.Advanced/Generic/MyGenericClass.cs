using master_csharp.App.Generic;

namespace master_csharp.App.Generic
{
    public class MyGenericClass<T>
    {
        private T data;

        public void SetData(T value)
        {
            data = value;
        }

        public T GetData()
        {
            return data;
        }
    }
}

class GenericUsage
{
    public static void Test()
    {
        MyGenericClass<int> intObj = new MyGenericClass<int>();
        intObj.SetData(42);
        Console.WriteLine(intObj.GetData()); // Output: 42

        MyGenericClass<string> stringObj = new MyGenericClass<string>();
        stringObj.SetData("Hello");
        Console.WriteLine(stringObj.GetData()); // Output: Hello
    }
}