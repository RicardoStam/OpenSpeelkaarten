using OpenSpeelkaarten.Structures.SLL;
using System;

namespace OpenSpeelkaarten.Structures.Queue
{
    class SLLQueue<T> : AbsQueue<T, ISingleLinkedList<T>>
    {
        public SLLQueue()
        {
            elements = new SingleLinkedList<T>();
        }

        public override T Dequeue()
        {
            T tmp = elements.GetEndValue();
            elements.DeleteEnd();
            return tmp;
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }

        public override void Enqueue(T value)
        {
            elements.Insert(value);
        }
    }
}
