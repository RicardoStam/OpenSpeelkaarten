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
            this.SetTail(null);
        }

        public ISingleLinkedListNode<T> GetNext()
        {
            return this.tail;
        }

        public T GetValue()
        {
            return this.value;
        }

        public bool IsEmpty()
        {
            return this.isEmpty;
        }

        public void SetTail(ISingleLinkedListNode<T> tail)
        {
            this.tail = tail;
        }
    }
}
