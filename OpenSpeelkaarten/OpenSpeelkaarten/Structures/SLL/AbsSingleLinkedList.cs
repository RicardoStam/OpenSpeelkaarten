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
            head = new SLLNode<T>(value, head);
        }
        public void InsertAtEnd(T value)
        {
            if (head.IsEmpty()) this.Insert(value);
            else
            {
                ISingleLinkedListNode<T> temp = head;
                while (!temp.GetNext().IsEmpty())
                {
                    temp = temp.GetNext();
                }
                temp.SetTail(new SLLNode<T>(value, temp.GetNext()));
            }
        }
        public void InsertAfter(T value, T targetValue)
        {
            if (head.IsEmpty()) throw new Exception("SLL is empty!");
            else
            {
                ISingleLinkedListNode<T> temp = head;
                while (!temp.IsEmpty() && !Equals(temp.GetValue(), targetValue)) temp = temp.GetNext();
                if (temp.IsEmpty()) throw new Exception("TagetValue not found within the list!");
                else temp.SetTail(new SLLNode<T>(value, temp.GetNext()));
            }

        }
        public void InsertBefore(T value, T targetValue)
        {
            throw new NotImplementedException();
        }

        // Deletions
        public void DeleteHead()
        {
            ISingleLinkedListNode<T> temp = head;
            head = temp.GetNext();
            temp.Disconnect();
        }
        public void DeleteEnd()
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
