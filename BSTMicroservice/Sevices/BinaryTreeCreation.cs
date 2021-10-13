using BSTMicroservice.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSTMicroservice.Sevices
{
    public class BinaryTreeCreation : IBinaryTreeCreation
    {
        public BinaryTree Creation(Node node)
        {
            BinaryTree tree = new BinaryTree(node);
            tree.insert(3, "Poland");
            tree.insert(4, "Slovakia");
            tree.insert(34, "Germany");
            tree.insert(22, "France");
            tree.insert(2, "Italy");
            tree.insert(44, "Monaco");
            tree.insert(42, "USA");
            tree.insert(55, "Mexico");
            tree.insert(38, "Kanada");


            
            return tree;
        }
    }
}
