using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Binary Search Tree Operation");
            MyBinaryNode<int> tree = new MyBinaryNode<int>(56);

            Console.WriteLine("Enter 1: Add Values\n" + "Enter 2: Exit\n");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    tree.Insert(30);
                    tree.Insert(70);
                    tree.Display();
                    break;

                default:
                    Console.WriteLine("Enter correct option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
