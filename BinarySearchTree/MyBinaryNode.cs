using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class MyBinaryNode<T> where T : IComparable<T>
    {
        public T nodeData { get; set; }
        public MyBinaryNode<T> leftTree { get; set; }

        public MyBinaryNode<T> rightTree { get; set; }

        public MyBinaryNode(T data)
        {
            this.nodeData = data;
            this.leftTree = null;
            this.rightTree = null;
        }
        int leftCount = 0, rightCount = 0;
        bool result = false;

        public void Insert(T item)
        {
            T CurrNodeVal = this.nodeData;
            if ((CurrNodeVal.CompareTo(item)) > 0)
            {
                if (this.leftTree == null)
                {
                    this.leftTree = new MyBinaryNode<T>(item);
                }
                else
                {
                    this.leftTree.Insert(item);
                }
            }
            else
            {
                if (this.rightTree == null)
                {
                    this.rightTree = new MyBinaryNode<T>(item);
                }
                else
                {
                    this.rightTree.Insert(item);

                }
            }
        }
        public void GetSize()     //for size calculation
        {
            Console.WriteLine("Size of the tree is" + (1 + this.leftCount + this.rightCount));
        }

        public bool IfExists(T element, MyBinaryNode<T> node)
        {
            if (node == null)
            {
                return false;
            }
            if (node.nodeData.Equals(element))
            {
                Console.WriteLine("Got the value in BST " + node.nodeData);
                result = true;
            }
            else
            {
                Console.WriteLine("Current value is {0} in BST ", node.nodeData);
            }
            if (element.CompareTo(node.nodeData) < 0)
            {
                IfExists(element, node.leftTree);
            }
            if (element.CompareTo(node.nodeData) > 0)
            {
                IfExists(element, node.rightTree);
            }

            return result;
        }

        public void Display()
        {
            if (this.leftTree != null)
            {
                this.leftCount++;
                this.leftTree.Display();
            }
            Console.WriteLine(this.nodeData.ToString());
            if (this.rightTree != null)
            {
                this.rightCount++;
                this.rightTree.Display();
            }
        }



    }
}

