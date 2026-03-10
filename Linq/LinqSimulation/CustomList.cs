using System;
using System.Collections;
using System.Collections.Generic;

namespace Linq_Simulation
{
    class CustomList<T> : IEnumerable<T>
    {
        public T[] array;

        public CustomList(T[] arr)
        {
            array = arr;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return new MDSEnumerator(this);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public class MDSEnumerator : IEnumerator<T>
        {
            int index = -1;
            CustomList<T> MDS;
            public MDSEnumerator(CustomList<T> MDS)
            {
                this.MDS = MDS;
            }
            public T Current
            {
                get
                {
                    if (index >= 0 && index < MDS.array.Length)
                    {
                        return MDS.array[index];
                    }
                    throw new InvalidOperationException("Enumerator is in an invalid state.");
                }
            }
            object IEnumerator.Current => Current;
            public void Dispose()
            {
            }
            public bool MoveNext()
            {
                if (index < MDS.array.Length - 1)
                {
                    index++;
                    return true;
                }
                return false;
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }
}
