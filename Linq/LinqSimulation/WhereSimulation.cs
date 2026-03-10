

using System.Collections;
using System.Collections.Generic;

namespace Linq_Simulation
{
    internal static class WhereSimulation
    {
        public delegate bool Del<T>(T x);

        public static IEnumerable<T> Where<T>(this IEnumerable<T> source, Del<T> D)
        {
            return new WhereIEnumerable<T>(source, D);
        }
        public class WhereIEnumerable<T> : IEnumerable<T>
        {
            private readonly IEnumerable<T> _source;
            private readonly Del<T> _predicate;

            public WhereIEnumerable(IEnumerable<T> source, Del<T> D)
            {
                _source = source;
                _predicate = D;
            }
            public IEnumerator<T> GetEnumerator()
            {
                return new WhereIEnumerator(_source, _predicate);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            public class WhereIEnumerator : IEnumerator<T>
            {
                private readonly IEnumerable<T> _source;
                private readonly Del<T> _predicate;
                private IEnumerator<T> _enumerator;
                public WhereIEnumerator(IEnumerable<T> source, Del<T> D)
                {
                    _source = source;
                    _predicate = D;
                    _enumerator = source.GetEnumerator();
                }
                public T Current => _enumerator.Current;
                object IEnumerator.Current => Current;


                public bool MoveNext()
                {
                    while (_enumerator.MoveNext())
                    {
                        if (_predicate(_enumerator.Current))
                        {
                            return true;
                        }
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
