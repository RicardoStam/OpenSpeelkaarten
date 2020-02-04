using System;

namespace OpenSpeelkaarten.Structures.Nodes.TreeNodes
{
    abstract class AbsTreeNode<T> : ITreeNode<T>
    {
        protected T value;
        protected ITreeNode<T> leftChild, rightChild, parent;

        public void Disconnect()
        {
             parent = null;
             leftChild = null;
             rightChild = null;
        }

        public ITreeNode<T> GetLeftChild()
        {
            return leftChild();
        }

        public ITreeNode<T> GetParent()
        {
            return parent;
        }

        public ITreeNode<T> GetRightChild()
        {
            return rightChild;
        }

        public T GetValue()
        {
            return value;
        }

        public bool IsLeaf()
        {
            return leftChild == null && rightChild == null;
        }

        public void SetLeftChild(ITreeNode<T> node)
        {
            leftChild = node;
        }

        public void SetPartent(ITreeNode<T> node)
        {
            parent = node;
        }

        public void SetRightChild(ITreeNode<T> node)
        {
            rightChild = node;
        }
    }
}
