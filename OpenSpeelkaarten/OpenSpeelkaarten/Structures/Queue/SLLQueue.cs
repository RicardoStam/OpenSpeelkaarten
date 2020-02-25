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

        // Insertion
        public override void Enqueue(T value)
        {
            elements.Insert(value);
        }

        // Deletion & Get value
        public override T Dequeue()
        {
            T temp = elements.GetEndValue();
            elements.DeleteEnd();
            return temp;
        }
        
        //Printer
        public override void Display()
        {
            elements.Display();
        }

        public override bool IsEmpty()
        {
            return elements.IsEmpty();
        }

        public override T Peek()
        {
            return elements.GetEndValue();
        }
    }
}
