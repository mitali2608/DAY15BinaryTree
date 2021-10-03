using System;
using System.Collections.Generic;
using System.Text;

namespace Day15BinarySearch
{
    class UC3Search63<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public UC3Search63<T> leftTree { get; set; }
        public UC3Search63<T> rightTree { get; set; }
        public UC3Search63(T nodeData)
        {
            this.NodeData = nodeData;
            this.rightTree = null;
            this.leftTree = null;
        }

        int leftCount = 0, rightCount = 0;
        bool result = false;

        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.leftTree == null)
                    this.leftTree = new UC3Search63<T>(item);

                else
                    this.leftTree.Insert(item);
                Console.WriteLine(item + " added to left");
            }
            else
            {
                if (this.rightTree == null)
                    this.rightTree = new UC3Search63<T>(item);

                else
                    this.rightTree.Insert(item);
                Console.WriteLine(item + " added to right");
            }
        }

        public bool Search(T element, UC3Search63<T> node)
        {
            if (node == null)
                return false;

            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Found the element in BST" + " " + node.NodeData);
                result = true;
            }
            else
                Console.WriteLine("Current element is {0} in BST", node.NodeData);

            if (element.CompareTo(node.NodeData) < 0)
                Search(element, node.leftTree);

            if (element.CompareTo(node.NodeData) > 0)
                Search(element, node.rightTree);

            return result;
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
