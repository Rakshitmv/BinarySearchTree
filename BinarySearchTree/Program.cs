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

            Console.WriteLine("Enter 1: Add Values\n" + "Enter 2: Add Values by given figure\n" +"Enter 3: Exit\n");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    tree.Insert(30);
                    tree.Insert(70);
                    tree.Display();
                    break;
                case 2:
                    tree.Insert(30);
                    tree.Insert(70);
                    tree.Insert(22);
                    tree.Insert(40);
                    tree.Insert(60);
                    tree.Insert(95);
                    tree.Insert(11);
                    tree.Insert(65);
                    tree.Insert(3);
                    tree.Insert(16);
                    tree.Insert(63);
                    tree.Insert(67);
                    tree.Display();
                    tree.GetSize();
                    break;
                case 3:
                    Console.WriteLine("Exit");
                    break;


                default:
                    Console.WriteLine("Enter correct option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
