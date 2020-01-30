﻿using System;

namespace OpenSpeelkaarten.Structures.Nodes.SingleLinkedListNodes
{
    class SLLNode<T> : AbsSingleLinkedListNode<T>
    {
        public SLLNode(T value, ISingleLinkedListNode<T> tail)
        {
            this.value = value;
            this.tail = tail;
            isEmpty = true;
        }
    }
}
