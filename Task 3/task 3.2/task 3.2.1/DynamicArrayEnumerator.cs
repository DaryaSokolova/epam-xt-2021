using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace task_3._2._1
{
    public class DynamicArrayEnumerator<T> : IEnumerator<T>
    {
        int position = -1;
        private T[] enumeratorArray;

        public DynamicArrayEnumerator(T[] array)
        {
            this.enumeratorArray = array;
        }

        public T Current
        {
            get
            {
                if (position == -1 || position >= enumeratorArray.Length)
                {
                    throw new InvalidOperationException();
                }

                return enumeratorArray[position];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose() { }

        public bool MoveNext()
        {
            if (position < enumeratorArray.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
