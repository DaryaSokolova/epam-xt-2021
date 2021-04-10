using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_3._2._1
{
    class DynamicArray<T> : ICollection<T>
    {
        private T[] array;
        private int capacity;

        public int Length
        {
            get
            {
                return array.Length;
            }
        }

        public int Capacity
        {
            get { return capacity; }

            set
            {

                if (array.Length == 0)
                {
                    capacity = 0;
                }
                else
                {
                    capacity = 1;
                }

                while (array.Length > capacity)
                {
                    capacity *= 2;
                }
            }
        }

        public DynamicArray()
        {
            array = new T[8];
            Capacity = -1;
        }

        public DynamicArray(int container)
        {
            array = new T[container];
            Capacity = -1;
        }

        public DynamicArray(IEnumerable<T> sourse)
        {
            array = sourse.ToArray();
            Capacity = -1;
        }

        private void CheckArgumentOutOfRangeException(int index)
        {
            if (index < 0 || index > array.Length)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public T this[int index]
        {
            get
            {
                CheckArgumentOutOfRangeException(index);

                return array[index];
            }

            set
            {
                CheckArgumentOutOfRangeException(index);

                array[index] = value;
            }
        }

        public void Add(T item)
        {
            T[] arr = new T[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                arr[i] = array[i];
            }

            arr[array.Length] = item;

            array = arr;

            Capacity = -1;
        }

        public void AddRange(IEnumerable<T> item)
        {
            T[] arr = new T[array.Length + item.ToArray().Length];

            for (int i = 0; i < array.Length; i++)
            {
                arr[i] = array[i];
            }

            int j = 0; T[] temp = item.ToArray();

            for (int i = array.Length; i < array.Length + temp.Length; i++)
            {
                arr[i] = temp[j];
                j++;
            }

            array = arr;

            Capacity = -1;
        }

        private int Find(T item)
        {
            for (int i = 0; i < array.Length + 1; i++)
            {
                T[] tempForFind = new T[i];
                for (int j = 0; j < tempForFind.Length; j++)
                {
                    tempForFind[j] = array[j];
                }

                if (tempForFind.Contains(item))
                {
                    return tempForFind.Length - 1;
                }
            }

            return -1;
        }

        public bool Remove(T item)
        {
            if (!Contains(item))
            {
                return false;
            }

            int index = Find(item);

            T[] tempForNewArray = new T[array.Length - 1];

            for (int i = 0; i < index; i++)
            {
                tempForNewArray[i] = array[i];
            }

            int j = 0; int count = index;

            for (int i = index + 1; i < array.Length; i++)
            {
                tempForNewArray[count] = array[i];
                j++;
                count++;
            }

            array = tempForNewArray;

            return true;
        }

        public bool Contains(T item)
        {
            if (array.Contains(item))
            {
                return true;
            }

            return false;
        }

        public bool Insert(T item, int index)
        {
            CheckArgumentOutOfRangeException(index);

            T[] tempArray = new T[array.Length + 1];

            for (int i = 0; i < index; i++)
            {
                tempArray[i] = array[i];
            }

            tempArray[index] = item;

            for (int i = index + 1; i < tempArray.Length; i++)
            {
                tempArray[i] = array[i - 1];
            }

            array = tempArray;

            Capacity = -1;

            if (array[index].Equals(item))
                return true;
            else
                return false;
        }

        public int Count
        {
            get
            {
                return array.Length;
            }
        }

        public void Clear()
        {
            array = new T[] { };
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new DynamicArrayEnumerator<T>(array);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new DynamicArrayEnumerator<T>(array);
        }

        public bool IsReadOnly => throw new NotImplementedException();

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }
    }
}
