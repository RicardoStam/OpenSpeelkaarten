using System;
using OpenSpeelkaarten.Structures.Nodes.SingleLinkedListNodes;

namespace OpenSpeelkaarten.Structures.SLL
{
    class AbsSingleLinkedList<T> : ISingleLinkedList<T>
    {
        protected ISingleLinkedListNode<T> head;

        // Insertions
        public void Insert(T value)
        {
            throw new NotImplementedException();
        }
        public void InsertAtEnd(T value)
        {
            throw new NotImplementedException();
        }
        public void InsertAfter(T value, T targetValue)
        {
            throw new NotImplementedException();
        }
        public void InsertBefore(T value, T targetValue)
        {
            throw new NotImplementedException();
        }

        // Deletion
        public void DeleteEnd()
        {
            throw new NotImplementedException();
        }
        public void DeleteHead()
        {
            throw new NotImplementedException();
        }
        public void DeleteSpecific(T value)
        {
            throw new NotImplementedException();
        }

        // Get values
        public T GetHeadValue()
        {
            throw new NotImplementedException();
        }
        public T GetEndValue()
        {
            throw new NotImplementedException();
        }
        public T GetIndexValue(int index)
        {
            throw new NotImplementedException();
        }

        // Printer
        public void Display()
        {
            throw new NotImplementedException();
        }

    }
}
