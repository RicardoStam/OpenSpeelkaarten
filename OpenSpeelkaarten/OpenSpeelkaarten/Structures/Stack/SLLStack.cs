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
        // Insertion
        public override void Push(T value)
        {
            elements.Insert(value);
        }
        
        // Deletion
        public override T Pop()
        {
            T value = elements.GetHeadValue();
            elements.DeleteHead();
            return value;
        }

        // Get value
        public override T Peek()
        {
            return elements.GetHeadValue();
        }

        // Misc
        public override bool IsEmpty()
        {
            return elements.IsEmpty();
        }

    }
}
