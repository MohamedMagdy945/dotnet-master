using System.Collections;
using System.Collections.Generic;

namespace Linq_Simulation
{
    internal static class TakeSimulation
    {

        public static IEnumerable<T> Take<T>(this IEnumerable<T> source,int value)
        {
            return new TakeIEnumerable<T>(source, value);
        }
        public class TakeIEnumerable<T> : IEnumerable<T>
        {
            private readonly IEnumerable<T> _source;
            private readonly int value;

            public TakeIEnumerable(IEnumerable<T> source, int value)
            {
                _source = source;
                this.value = value;
            }
            public IEnumerator<T> GetEnumerator()
            {
                return new TakeIEnumerator(_source, value);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            public class TakeIEnumerator : IEnumerator<T>
            {
                private readonly IEnumerable<T> _source;
                private readonly int value;
                private  int _taken;
                private IEnumerator<T> _enumerator;
                public TakeIEnumerator(IEnumerable<T> source, int value)
                {
                    _source = source;
                    this.value = value;
                    _enumerator = source.GetEnumerator();
                    _taken = 0;
                }
                public T Current => _enumerator.Current;
                object IEnumerator.Current => Current;

                public bool MoveNext()
                {
                    if (_taken >= value)
                    {
                        return false;
                    }
                    if (_enumerator.MoveNext())
                    {
                        _taken++;
                        return true;
                    }
                    return false;
                }

                public void Reset()
                {
                    _enumerator = _source.GetEnumerator();
                }
                public void Dispose()
                {
                    _enumerator.Dispose();
                }

            }
        }
    }
}
