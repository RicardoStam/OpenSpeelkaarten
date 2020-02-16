using OpenSpeelkaarten.Comparators;
using System;
using System.Collections.Generic;

namespace OpenSpeelkaarten.Sorters.List
{
    class AbsListSort<T> : ISort<T, List<T>>
    {
        protected IComparator<T> comparator;

        public List<T> BubbleSort(List<T> list)
        {
            throw new NotImplementedException();
        }

        public List<T> InsertionSort(List<T> list)
        {
            throw new NotImplementedException();
        }

        public List<T> MergeSort(List<T> list, int leftIndex, int rightIndex)
        {
            throw new NotImplementedException();
        }
    }
}
