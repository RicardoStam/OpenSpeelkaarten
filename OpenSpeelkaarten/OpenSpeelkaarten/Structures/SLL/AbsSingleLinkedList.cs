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
            if (head.IsEmpty()) throw new Exception("The list is empty!");
            else if (head.GetNext().IsEmpty()) DeleteHead();
            {
                ISingleLinkedListNode<T> actual = head, before = head;
                while (!actual.GetNext().IsEmpty())
                {
                    before = actual;
                    actual = actual.GetNext();
                }
                before.SetTail(actual.GetNext());
                actual.Disconnect();
            }
        }
        public void DeleteHead()
        {
            ISingleLinkedListNode<T> temp = head;
            head = head.GetNext();
            temp.Disconnect();
        }
        public void DeleteSpecific(T value)
        {
            if (head.IsEmpty()) throw new Exception("The list is empty!");
            else if (Equals(head.GetValue(), value)) DeleteHead();
            else
            {
                ISingleLinkedListNode<T> actual = head, before = head;
                while (!actual.IsEmpty() && !Equals(actual.GetValue(), value))
                {
                    before = actual;
                    actual = actual.GetNext();
                }
                if (actual.IsEmpty()) throw new Exception("The value is not present within the list.");
                before.SetTail(actual.GetNext());
                actual.Disconnect();
            }
        }

        // Get values
        public T GetHeadValue()
        {
            if (head.IsEmpty()) throw new Exception("The list is empty!");
            else return head.GetValue();
        }
        public T GetEndValue()
        {
            if (head.IsEmpty()) throw new Exception("The list is empty!");
            else
            {
                ISingleLinkedListNode<T> temp = head;
                while (!temp.GetNext().IsEmpty()) temp = temp.GetNext();
                return temp.GetValue();
            }
        }
        public T GetIndexValue(int index)
        {
            if (head.IsEmpty()) throw new Exception("The list is empty!");
            else if (index < 0) throw new Exception("A index can only be positive.");
            else
            {
                ISingleLinkedListNode<T> temp = head;
                int localIndex = 0;
                while (localIndex != index && !temp.IsEmpty())
                {
                    temp = temp.GetNext();
                    localIndex++;
                }
                if (temp.IsEmpty()) throw new Exception("Index is out of bounds.");
                return temp.GetValue();
            }
        }

        // Printer
        public void Display()
        {
            if (head.IsEmpty()) throw new Exception("The list is empty!");
            else
            {
                ISingleLinkedListNode<T> temp = head;
                Console.WriteLine("Start");
                while (!temp.IsEmpty())
                {
                    Console.WriteLine(temp.GetValue().ToString());
                    temp = temp.GetNext();
                }
                Console.WriteLine("end");
            }
        }

        public bool IsEmpty()
        {
            return head.IsEmpty();
        }
    }
}
