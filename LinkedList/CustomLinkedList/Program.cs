using System;

namespace DataStructure_CustomLinkedList
{
    class Program
    {
        static void Main()
        {
            CustomLinkedList list = new CustomLinkedList();
        }
    }

    /// <summary>
    /// Represents a single node in the linked list.
    /// Each node holds a data value and a reference to the next node.
    /// </summary>
    class Node
    {
        public int Data { get; } // Data is read-only for security
        public Node? Next { get; private set; } // Next node can only be changed inside the class
        
        public Node(int data)
        {
            this.Data = data;
            this.Next = null;
        }
        
        /// <summary>
        /// Sets the next node in the linked list.
        /// </summary>
        public void SetNext(Node nextNode)
        {
            this.Next = nextNode;
        }
    }

    /// <summary>
    /// A simple custom implementation of a singly linked list.
    /// Supports adding elements to the end and displaying the list.
    /// </summary>
    class CustomLinkedList
    {
        private Node? Head; // Head node is private to ensure safety

        public CustomLinkedList()
        {
            Head = null;
        }

        /// <summary>
        /// Adds a new node with the given data to the end of the list.
        /// </summary>
        public void AddLast(int data)
        {
            Node current = new Node(data);
            if (Head == null)
            {
                Head = current;
            }
            else
            {
                Node temp = Head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.SetNext(current);
            }
        }

        /// <summary>
        /// Displays the entire linked list in a readable format.
        /// </summary>
        public void ShowInfo()
        {
            Node? show = Head;
            while (show != null)
            {
                Console.Write($"{show.Data} --->>> ");
                show = show.Next;
            }
            Console.Write("NULL");
        }
    }
}
