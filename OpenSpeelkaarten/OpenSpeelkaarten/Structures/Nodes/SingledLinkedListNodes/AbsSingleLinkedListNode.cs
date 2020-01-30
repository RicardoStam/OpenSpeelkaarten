using System;

namespace OpenSpeelkaarten.Structures.Nodes.SingleLinkedListNodes
{
    abstract class AbsSingleLinkedListNode<T> : ISingleLinkedListNode<T>
    {
        protected bool isEmpty;
        protected T value;
        protected ISingleLinkedListNode<T> tail;

        public void Disconnect()
        {
            tail = null;
        }

        public ISingleLinkedListNode<T> GetNext()
        {
            return tail;
        }

        public T GetValue()
        {
            return value;
        }

        public bool IsEmpty()
        {
            return isEmpty;
        }

        public void SetTail(ISingleLinkedListNode<T> tail)
        {
            this.tail = tail;
        }
    }
}
