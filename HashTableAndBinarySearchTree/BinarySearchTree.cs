using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableAndBinarySearchTree
{
    public class BinarySearchTree
    {
        public Node root;
        public BinarySearchTree()
        {
            root = null;
        }
        public void Insert(int data)
        {
            //Create a new node  
            Node newNode = new Node(data);
            //Check whether tree is empty  
            if (root == null)
            {
                root = newNode;
                return;
            }
            else
            {
                //current node point to root of the tree  
                Node current = root, parent;
                while (true)
                {
                    //parent keep track of the parent node of current node.  
                    parent = current;
                    //If data is less than current's data, node will be inserted to the left of tree  
                    if (data < current.data)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = newNode;
                            return;
                        }
                    }
                    //If data is greater than current's data, node will be inserted to the right of tree  
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newNode;
                            return;
                        }
                    }
                }
            }
        }
        public void Display(Node node)
        { 
            if (root == null)
            {
                Console.WriteLine("Tree is empty");
            }
            else
            {
               //Inorder left->root->right
                if (node.left != null)
                    Display(node.left);
                Console.WriteLine(node.data + " ");
                if (node.right != null)
                    Display(node.right);

            }
        }

    }
}
