using OpenSpeelkaarten.Comparators;
using System;

namespace OpenSpeelkaarten.Sorters.Array
{
    abstract class AbsArraySort<T> : ISort<T, T[]>
    {
        protected IComparator<T> comparator;

        public T[] BubbleSort(T[] list)
        {
            throw new NotImplementedException();
        }

        public T[] InsertionSort(T[] list)
        {
            throw new NotImplementedException();
        }

        public T[] MergeSort(T[] list, int leftIndex, int rightIndex)
        {
            throw new NotImplementedException();
        }
    }
}
