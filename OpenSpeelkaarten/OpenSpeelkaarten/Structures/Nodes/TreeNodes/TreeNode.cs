using System;

namespace OpenSpeelkaarten.Structures.Nodes.TreeNodes
{
    class TreeNode<T> : AbsTreeNode<T>
    {
        public TreeNode(T value, ITreeNode<T> parent = null)
        {
            this.value = value;
            this.parent = parent;
        }
    }
}
