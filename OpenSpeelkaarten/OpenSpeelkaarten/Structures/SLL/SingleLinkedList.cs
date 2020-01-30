using OpenSpeelkaarten.Structures.Nodes.SingleLinkedListNodes;
using System;


namespace OpenSpeelkaarten.Structures.SLL
{
    class SingleLinkedList<T> : AbsSingleLinkedList<T>
    {
        public SingleLinkedList()
        {
            head = new EmptySLLNode<T>();
        }
    }
}
