using OpenSpeelkaarten.Comparators;
using OpenSpeelkaarten.Structures.Nodes.TreeNodes;
using System;

namespace OpenSpeelkaarten.Structures.Tree
{
    abstract class AbsTree<T> : ITree<T>
    {
        protected ITreeNode<T> root;
        protected IComparator<T> comparator;

        public void Add(T value, ITreeNode<T> node)
        {
            T nodeValue = node.GetValue();
            if(nodeValue < value)
            {
                if(node.GetRightChild() == null) node.SetRightChild(new TreeNode(value, node));
                else Add(value, node.GetRightChild());
            }
            else if(nodeValue > value)
            {
                if(node.GetLeftChild() == null) node.SetLeftChild(new TreeNode(value, node));
                else Add(value, node.GetLeftChild());
            }
        }
        private ITreeNode<T> RecursiveRemove(ITreeNode<T> node, T value)
        {    
            if (key < node.GetValue()) node.SetLeftChild(RecursiveRemove(node.GetLeftChild(), key));  
            else if (key > node.GetValue()) node.SetRightChild(RecursiveRemove(node.GetRightChild(), key));  
            else
            {  
                if (node.GetLeftChild() == null) return root.right;  
                else if (node.GetRightChild() == null) return root.left; 

                root.key = GetLowestValue(node.GetRightChild());  
                root.right = RecursiveRemove(node.GetRightChild(), node.GetValue());  
            }  
            return root;  
        }

        public void Remove(T value)
        {   
            if (root == null) return; 
            root = RecursiveRemove(root, value);
        }
        public void TraverseInOrder(ITreeNode<T> node)
        {
            throw new NotImplementedException();
        }

        public void TraversePostOrder(ITreeNode<T> node)
        {
            throw new NotImplementedException();
        }

        public void TraversePreOrder(ITreeNode<T> node)
        {
            throw new NotImplementedException();
        }
    }
}
