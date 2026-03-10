
using test;

namespace master_csharp.Advanced2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var testsss = new top<string, string>();
            Console.WriteLine(sizeof(char)); // النتيجة هتكون 2
        }
       
    }
}

namespace test
{
    public class top<T1 , T2>
    {

    }
}
namespace test2
{
    public class folk
    {
        public static top<s, e> tesss<s , e>(s item1 , e item2)
        {
            return new top<s, e> () ;
        }
    }
}
