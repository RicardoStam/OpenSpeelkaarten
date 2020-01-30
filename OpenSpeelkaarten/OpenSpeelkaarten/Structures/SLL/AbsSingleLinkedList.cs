using System;
using OpenSpeelkaarten.Structures.Nodes.SingleLinkedListNodes;

namespace OpenSpeelkaarten.Structures.SLL
{
    class AbsSingleLinkedList<T> : ISingleLinkedList<T>
    {
        protected ISingleLinkedListNode<T> head;

        public void DeleteEnd()
        {
            ISingleLinkedListNode<T> tmp = head, tmp1 = head;

            while (!tmp.GetNext().IsEmpty())
            {
                tmp1 = tmp;
                tmp = tmp.GetNext();
            }
            tmp1.SetTail(tmp.GetNext());
            tmp.Disconnect();
        }
        

        public void DeleteHead()
        {
            ISingleLinkedListNode<T> tmp = head;
            head = head.GetNext();
            tmp.Disconnect();
        }

        public void DeleteSpecific(T value)
        {
            ISingleLinkedListNode<T> tmp = head, tmp1 = head;

            while (Equals(tmp.GetValue(),value))
            {
                tmp1 = tmp;
                tmp = tmp.GetNext();
            }
            if (tmp.IsEmpty()) throw new Exception("Number not present in the list.");

            tmp1.SetTail(tmp.GetNext());
            tmp.Disconnect();
        }

        public void Display()
        {
            ISingleLinkedListNode<T> tmp = head;

            while (!tmp.IsEmpty())
            {
                Console.WriteLine(tmp.GetValue().ToString());
            }
            Console.WriteLine("empty node");
        }

        public void InsertAfter(T value, T targetValue)
        {
            ISingleLinkedListNode<T> tmp = head, tmp1 = head;

            while (Equals(tmp.GetValue(), targetValue))
            {
                tmp1 = tmp;
                tmp = tmp.GetNext();
            }
            if (tmp.IsEmpty()) throw new Exception("Number not present in the list.");
            tmp.SetTail(new SLLNode<T>(value, tmp.GetNext()));
        }

        public void Insert(T value)
        {
            head = new SLLNode<T>(value, head);
        }

        public void InsertAtEnd(T value)
        {
            ISingleLinkedListNode<T> tmp = head;

            while (!tmp.GetNext().IsEmpty())
            { 
                tmp = tmp.GetNext();
            }
            tmp.SetTail(new SLLNode<T>(value, tmp.GetNext()));
        }

        public T GetHeadValue()
        {
            return head.GetValue();
        }

        public T GetEndValue()
        {
            ISingleLinkedListNode<T> tmp = head;

            while (!tmp.GetNext().IsEmpty())
            {
                tmp = tmp.GetNext();
            }
            return tmp.GetValue();
        }

        public bool IsEmpty()
        {
            return head.IsEmpty();
        }
    }
}
