using System;
using System.Collections.Generic;
using System.Text;

namespace Day15BinarySearch
{
    class UC2BinaryTreeCreation<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public UC2BinaryTreeCreation<T> leftTree { get; set; }
        public UC2BinaryTreeCreation<T> rightTree { get; set; }
        public UC2BinaryTreeCreation(T nodeData)
        {
            this.NodeData = nodeData;
            this.rightTree = null;
            this.leftTree = null;
        }

        int leftCount = 0, rightCount = 0;

        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.leftTree == null)
                    this.leftTree = new UC2BinaryTreeCreation<T>(item);

                else
                    this.leftTree.Insert(item);
                Console.WriteLine(item + " added to left");
            }
            else
            {
                if (this.rightTree == null)
                    this.rightTree = new UC2BinaryTreeCreation<T>(item);

                else
                    this.rightTree.Insert(item);
                Console.WriteLine(item + " added to right");
            }
        }

        public void Display()
        {
            if (this.leftTree != null)
            {
                this.leftCount++;
                this.leftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());

            if (this.rightTree != null)
            {
                this.rightCount++;
                this.rightTree.Display();
            }
        }
    }
}
