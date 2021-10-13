using System;
using System.Collections.Generic;
using System.Text;

namespace BSTMicroservice.Classes
{
    public class Node
    {
        private int nodeKey;
        public int NodeKey{ get { return nodeKey; } }

        private string nodeValue;
        public string NodeValue { get { return nodeValue; } }

        private Node rightNode;
        public Node Rightnode
        {
            get { return rightNode; }
            set { rightNode = value; }
        }

        private Node leftNode;

        public Node LeftNode
        {
            get { return leftNode; }
            set { leftNode = value; }
        }

        public Node(int key, string data)
        {
            this.nodeKey = key;
            this.nodeValue = data;
        }

        public void insert(int key, string data)
        {
            if (key == this.nodeKey)
            {
                Console.WriteLine($"You are tring to insert value: {data} into key: {key}.");
                Console.WriteLine($"This key already exist. Current data: {this.nodeValue}. Replace the data? (y - yes, anything else - no)");
                string line = Console.ReadLine();
                if(line == "y")
                {
                    this.nodeValue = data;
                }
            }
            else if (key > this.nodeKey)
            {
                if (rightNode == null)
                {
                    rightNode = new Node(key, data);
                    Console.WriteLine($"Inserted value {data}, key {key}.");
                }
                else
                {
                    rightNode.insert(key, data);
                }
            }
            else
            {
                if (leftNode == null)
                {
                    leftNode = new Node(key, data);
                    Console.WriteLine($"Inserted value {data}, key {key}.");
                }
                else
                {
                    leftNode.insert(key, data);
                }
            }
        }

        public string InOrderTraversal()
        {
            if (leftNode != null)
                leftNode.InOrderTraversal();
            
            if (rightNode != null)
                rightNode.InOrderTraversal();
            return $"Key: {this.nodeKey}, Data: {this.nodeValue}. ";
        }
    }
}
