using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableAndBinarySearchTree
{
    public class BinarySearchTreeUsingGenerics<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public BinarySearchTreeUsingGenerics<T> LeftTree { get; set; }
        public BinarySearchTreeUsingGenerics<T> RightTree { get; set; }
        public BinarySearchTreeUsingGenerics(T nodeData)
        {
            NodeData = nodeData;
            LeftTree = null;
            RightTree = null;
        }
        public int leftCount = 0, rightCount = 0;
        public bool result = false;
        //INSERTION
        public void Insert(T item)
        {
            T currentNodeValue = NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (LeftTree == null)
                {
                    leftCount++;
                    LeftTree = new BinarySearchTreeUsingGenerics<T>(item); 
                }
                else
                {
                    LeftTree.Insert(item);
                    leftCount++;
                }
               // Console.WriteLine(leftCount);
            }
            else
            {
                if (RightTree == null)
                {
                    rightCount++;
                    RightTree = new BinarySearchTreeUsingGenerics<T>(item);
                }
                else
                {
                    rightCount++;
                    RightTree.Insert(item);
                }
            }
        }
        
        public void GetSize()
        {
            int noOfNodes=leftCount+rightCount+1;
            Console.WriteLine("Number of element in BST is " + noOfNodes);
        }

        public void Display()
        {
            if (LeftTree != null)            
                LeftTree.Display();            
            Console.WriteLine(NodeData);
            if (RightTree != null)            
                RightTree.Display();
        }

    }
}



