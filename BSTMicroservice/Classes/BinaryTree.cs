using System;
using System.Collections.Generic;
using System.Text;

namespace BSTMicroservice.Classes
{
    public class BinaryTree
    {
        private Node root;
        public Node Root
        {
            get { return root; }
        }

        public BinaryTree(Node root)
        {
            this.root = root;
        }

        public void insert(int key, string data)
        {
            root.insert(key, data);
        }

        public string InOrderTraversal()
        {
            //Left->Root->Right
            return root.InOrderTraversal();
        }

    }
}
