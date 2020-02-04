using System;
using OpenSpeelkaarten.Structures.Nodes.SingleLinkedListNodes;

namespace OpenSpeelkaarten.Structures.SLL
{
    class AbsSingleLinkedList<T> : ISingleLinkedList<T>
    {
        protected ISingleLinkedListNode<T> head;

        public void DeleteEnd()
        {
            //Handle a empty list; throw an exception.
            if(IsEmpty()) throw new Exception("List is already empty");
            
            //Handle the cases in which there is only one node present.
            ISingleLinkedListNode<T> tmp = head; 
            if(tmp.GetNext().IsEmpty())
            {
                head = tmp.GetNext();
                tmp.Disconnect();
                return;
            }

            //Base cases.
            ISingleLinkedListNode<T> tmp1 = head;
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
            if(IsEmpty()) throw new Exception("List is already empty");
            ISingleLinkedListNode<T> tmp = head;
            head = head.GetNext();
            tmp.Disconnect();
        }

        public void DeleteSpecific(T value)
        {
            if(IsEmpty()) throw new Exception("List is already empty");
            ISingleLinkedListNode<T> tmp = head, tmp1 = head;

            while (!tmp.IsEmpty())
            {
                if(quals(tmp.GetValue(),value))break;
                tmp1 = tmp;
                tmp = tmp.GetNext();    
            }
            if (!quals(tmp1.GetValue(),value)) throw new Exception("Number not present in the list.");

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
            if(IsEmpty()) throw new Exception("List is empty");
            ISingleLinkedListNode<T> tmp = head, tmp1 = head;

            while (!tmp.IsEmpty())
            {
                tmp1 = tmp;
                tmp = tmp.GetNext();    
                if(quals(tmp.GetValue(),value))break;
            }
            if (!quals(tmp1.GetValue(),value)) throw new Exception("Number not present in the list.");
            tmp1.SetTail(new SLLNode<T>(value, tmp));
        }

        public void Insert(T value)
        {
            head = new SLLNode<T>(value, head);
        }

        public void InsertAtEnd(T value)
        {
            if(IsEmpty())
            {
                Insert(value);
                return;
            }

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
            if(IsEmpty()) throw new Exception("List is empty");
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
