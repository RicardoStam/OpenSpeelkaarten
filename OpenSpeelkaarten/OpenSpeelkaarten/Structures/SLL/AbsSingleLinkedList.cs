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
            head = new SLLNode<T>(value, head.GetNext());
        }
        public void InsertAtEnd(T value)
        {
            if (head.IsEmpty()) Insert(value);
            else
            {
                ISingleLinkedListNode<T> temp = head;
                while (!temp.GetNext().IsEmpty()) temp = temp.GetNext();
                temp.SetTail(new SLLNode<T>(value, temp.GetNext()));
            }
        }
        public void InsertAfter(T value, T targetValue)
        {
            if (head.IsEmpty()) throw new Exception("The List is empty!");
            else
            {
                ISingleLinkedListNode<T> temp = head;
                while (!temp.IsEmpty() && !Equals(temp.GetValue(), targetValue)) temp = temp.GetNext();
                if (temp.IsEmpty()) throw new Exception("The value is not present within the list.");
                temp.SetTail(new SLLNode<T>(value, temp.GetNext()));
            }
        }
        public void InsertBefore(T value, T targetValue)
        {
            if (head.IsEmpty()) throw new Exception("The list is empty!");
            else if (Equals(head.GetValue(), targetValue)) Insert(value);
            else
            {
                ISingleLinkedListNode<T> actual = head, before = head;
                while(!actual.IsEmpty() && !Equals(actual.GetValue(), targetValue))
                {
                    before = actual;
                    actual = actual.GetNext();
                }
                if (actual.IsEmpty()) throw new Exception("The value is ot present in the list.");
                before.SetTail(new SLLNode<T>(value, actual));
            }
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
