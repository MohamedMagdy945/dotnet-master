
using master_csharp.App.Enumerator;
using System.Collections;

namespace master_csharp.App.Enumerator
{
    class MyCollectionYeild : IEnumerable<int>
    {
        private int[] data = { 1, 2, 3, 4 };

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < data.Length; i++)
                yield return data[i]; // yield return بيعمل Enumerator تلقائي
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
class EnumeratorUsage
{
    static void Test()
    {
        MyCollectionYeild col = new MyCollectionYeild();
        foreach (var x in col)
            Console.WriteLine(x);
    }
}
