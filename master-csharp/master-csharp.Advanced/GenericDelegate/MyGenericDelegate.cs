
namespace master_csharp.App.GenericDelegate
{
    public delegate T MyGenericDelegate<T>(T value);

    public class MyGenericDelegate
    {
        public static int Square(int x)
        {
            return x * x;
        }

        public static string AddHello(string name)
        {
            return "Hello " + name;
        }

        public static void Test()
        {
            // استخدام Generic Delegate مع int
            MyGenericDelegate<int> delInt = Square;
            Console.WriteLine(delInt(5)); // Output: 25

            // استخدام Generic Delegate مع string
            MyGenericDelegate<string> delString = AddHello;
            Console.WriteLine(delString("Alice")); // Output: Hello Alice
        }
    }
}
