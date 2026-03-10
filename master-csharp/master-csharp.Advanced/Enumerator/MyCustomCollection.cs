using master_csharp.App.Enumerator;
using System.Collections;
namespace master_csharp.App.Enumerator
{
    class MyCustomCollection<T> : IEnumerable<T>
    {
        private T[] data ;
        public MyCustomCollection(T[] data)
        {
            this.data = data;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return new MyEnumerator<T>(this.data);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    class MyEnumerator<T> : IEnumerator<T>
    {
        private T[] _data;
        private int _position = -1;

        public MyEnumerator(T[] items)
        {
            this._data = items;    
        }
        public T Current
        {
            get
            {
                if (_position < 0 || _position >= _data.Length)
                    throw new InvalidOperationException();
                return _data[_position];
            }
        }

        object IEnumerator.Current => Current;


        public bool MoveNext()
        {
            _position++;
            return (_position < _data.Length);
        }

        public void Reset()
        {
            _position = -1;
        }

        public void Dispose()
        {
        }
    }
}
class CustomCollectionUsage
{
    public static void Test()
    {
        MyCustomCollection<int> col = new MyCustomCollection<int>(new int[]{ 1, 2 , 3 , 4 ,30 , 40 ,54,55});

        //foreach (var x in col)
        //{
        //    Console.WriteLine(x);
        //}

        IEnumerator enumerator = col.GetEnumerator();
        while (enumerator.MoveNext())
        {
            Console.WriteLine(enumerator.Current);
        }
    }
}
