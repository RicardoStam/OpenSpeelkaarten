using OpenSpeelkaarten.Structures.SLL;
using System;

namespace OpenSpeelkaarten.Structures.Stack
{
    class SLLStack<T> : AbsStack<T, ISingleLinkedList<T>>
    {
        public SLLStack()
        {
            elements = new SingleLinkedList<T>();
        }

        public override bool IsEmpty()
        {
            return elements.IsEmpty();
        }

        public override T Peek()
        {
            return elements.GetHeadValue();
        }

        public override T Pop()
        {
            T tmp = elements.GetHeadValue();
            elements.DeleteHead();
            return tmp;
        }

        public override void Push(T value)
        {
            elements.Insert(value);
        }
    }
}
