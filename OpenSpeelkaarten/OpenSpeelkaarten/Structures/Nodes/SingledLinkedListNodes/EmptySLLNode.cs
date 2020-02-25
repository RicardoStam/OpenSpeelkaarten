using System;

namespace OpenSpeelkaarten.Structures.Nodes.SingleLinkedListNodes
{
    class EmptySLLNode<T> : AbsSingleLinkedListNode<T>
    {
        public EmptySLLNode() 
        {
            this.isEmpty = true;
        }
    }
}
