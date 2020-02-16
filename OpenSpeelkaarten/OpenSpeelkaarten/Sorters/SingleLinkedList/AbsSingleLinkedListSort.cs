using OpenSpeelkaarten.Comparators;
using OpenSpeelkaarten.Structures.SLL;
using System;

namespace OpenSpeelkaarten.Sorters.SingleLinkedList
{
    class AbsSingleLinkedListSort<T> : ISort<T, ISingleLinkedList<T>>
    {
        protected IComparator<T> comparator;

        public ISingleLinkedList<T> BubbleSort(ISingleLinkedList<T> list)
        {
            throw new NotImplementedException();
        }

        public ISingleLinkedList<T> InsertionSort(ISingleLinkedList<T> list)
        {
            throw new NotImplementedException();
        }

        public ISingleLinkedList<T> MergeSort(ISingleLinkedList<T> list, int leftIndex, int rightIndex)
        {
            throw new NotImplementedException();
        }
    }
}
