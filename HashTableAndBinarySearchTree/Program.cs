using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableAndBinarySearchTree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to hash table programming");

            Console.WriteLine("1. Frequency of word in a sentence \n2. Frequency of word in a paragraph \n3. Removal of word " +
                "\n4. Create Binary Tree \n5. BST according to diagram");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    string para = "To be or not to be";
                    CountNumbOfOccurence(para);
                    break;
                case 2:
                    string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
                    CountNumbOfOccurence(paragraph);
                    break;
                case 3:
                    string text = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
                    CountNumbOfOccurence(text);
                    break;
                case 4:
                    BinarySearchTree binary = new BinarySearchTree();
                    binary.Insert(56);
                    binary.Insert(30);
                    binary.Insert(70);
                    binary.Display(binary.root);//30 56 70
                    break;
                case 5:
                    BinarySearchTreeUsingGenerics<int> binaryG = new BinarySearchTreeUsingGenerics<int>(56);
                    binaryG.Insert(33);
                    binaryG.Insert(70);
                    binaryG.Insert(22);
                    binaryG.Insert(40);
                    binaryG.Insert(60);
                    binaryG.Insert(95);
                    binaryG.Insert(11);
                    binaryG.Insert(3);
                    binaryG.Insert(16);
                    binaryG.Insert(65);
                    binaryG.Insert(63);
                    binaryG.Insert(67);
                    binaryG.Display();//3 11 16 22 33 40 56 60 63 65 67 70 95
                    binaryG.GetSize();
                    break;
                default:
                    Console.WriteLine("Please Enter the correct choice");
                    break;
            }
            Console.ReadLine();
        }
        public static void CountNumbOfOccurence(string paragraph)
        {
            MyNode<string, int> hashTable = new MyNode<string, int>(6);
            string[] words = paragraph.Split(' ');

            foreach (string word in words)
            {
                if (hashTable.Exists(word.ToUpper()))
                    hashTable.Add(word.ToUpper(), hashTable.Get(word.ToUpper()) + 1);
                else
                    hashTable.Add(word.ToUpper(), 1); 
            }
            Console.WriteLine(" Frequency of words in sentence");
            hashTable.Display();
            string w = "avoidable";
            hashTable.Remove(w.ToUpper());
            Console.WriteLine("After removed an item {0}", w);
            hashTable.Display();
        }
    }
}
  


