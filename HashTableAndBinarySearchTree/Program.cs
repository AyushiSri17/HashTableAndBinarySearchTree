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

            Console.WriteLine("1. Frequency of word in a sentence \n2. Frequency of word in a paragraph");
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
                default:
                    Console.WriteLine("Please Enter the correct choice");
                    break;
            }
            Console.ReadLine();
        }
        public static void CountNumbOfOccurence(string paragraph)
        {
            MyNode<string, int> hashTabe = new MyNode<string, int>(6);
            string[] words = paragraph.Split(' ');

            foreach (string word in words)
            {
                if (hashTabe.Exists(word.ToUpper()))
                    hashTabe.Add(word.ToUpper(), hashTabe.Get(word.ToUpper()) + 1);
                else
                    hashTabe.Add(word.ToUpper(), 1); 
            }
            Console.WriteLine(" Frequency of words in sentence");
            hashTabe.Display();
        }
    }
}
  


