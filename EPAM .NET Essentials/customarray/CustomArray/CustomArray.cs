using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomArray
{
    public class CustomArray<T> : IEnumerable<T>
    {
        private readonly T[] array;
        private readonly int firstIndex;

        /// <summary>
        /// Should return firstIndex index of array
        /// </summary>
        public int First 
        { 
            get => firstIndex;
        }

        /// <summary>
        /// Should return last index of array
        /// </summary>
        public int Last 
        {
            get => firstIndex + array.Length - 1;
        }

        /// <summary>
        /// Should return length of array
        /// <exception cref="ArgumentException">Thrown when value was smaller than 0</exception>
        /// </summary>
        public int Length 
        {   
            get => array.Length;
        }

        /// <summary>
        /// Should return array 
        /// </summary>
        public T[] Array
        { 
            get => array;
        }


        /// <summary>
        /// Constructor with firstIndex index and length
        /// </summary>
        /// <param name="firstIndex">First Index</param>
        /// <param name="length">Length</param>
        public CustomArray(int firstIndex, int length)
        {
            if (length <= 0)
            {
                throw new ArgumentException("Length must be positive.");
            }

            this.firstIndex = firstIndex;
            array = new T[length];
        }


        /// <summary>
        /// Constructor with firstIndex index and collection  
        /// </summary>
        /// <param name="firstIndex">First Index</param>
        /// <param name="list">Collection</param>
        ///  <exception cref="ArgumentNullException">Thrown when list is null</exception>
        public CustomArray(int firstIndex, IEnumerable<T> list)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list));
            }

            int length = 0;
            foreach (var item in list)
            {
                ++length;
            }

            if (length == 0)
            {
                throw new ArgumentException("List cannot be empty.");
            }

            this.firstIndex = firstIndex;
            array = new T[length];
            int i = 0;
            foreach (var item in list)
            {
                array[i++] = item;
            }
        }

        /// <summary>
        /// Constructor with firstIndex index and params
        /// </summary>
        /// <param name="firstIndex">First Index</param>
        /// <param name="list">Params</param>
        ///  <exception cref="ArgumentNullException">Thrown when list is null</exception>
        /// <exception cref="ArgumentException">Thrown when list without elements </exception>
        public CustomArray(int firstIndex, params T[] list)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list));
            }

            if (list.Length == 0)
            {
                throw new ArgumentException("List cannot be empty.");
            }

            this.firstIndex = firstIndex;
            array = list;
        }

        /// <summary>
        /// Indexer with get and set  
        /// </summary>
        /// <param name="item">Int index</param>        
        /// <returns></returns>
        /// <exception cref="ArgumentException">Thrown when index out of array range</exception> 
        /// <exception cref="ArgumentNullException">Thrown in set  when value passed in indexer is null</exception>
        public T this[int item]
        {
            get
            {
                if (item < firstIndex || item > Last)
                {
                    throw new ArgumentException("Index is out of range.");
                }

                return array[item - firstIndex];
            }
            set
            {
                if (item < firstIndex || item > Last)
                {
                    throw new ArgumentException("Index is out of range.");
                }

                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                array[item - firstIndex] = value;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)array).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return array.GetEnumerator();
        }
    }
}
