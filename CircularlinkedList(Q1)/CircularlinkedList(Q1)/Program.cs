using System;

namespace CircularLinkedList_Q1_
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int value)
        {
            data = value;
            next = null;
        }
    }

    public class CircularLinkedList
    {
        public static Node head;

        public CircularLinkedList()
        {
            head = null;
        }

        public void AddFirst(int value)
        {
            if (head == null)
            {
                head = new Node(value);
                head.next = head;
            }
            else
            {
                Node newHead = new Node(value);
                newHead.next = head;
                head = newHead;
            }
        }

        public void AddLast(int value)
        {
            if (head == null)
            {
                head = new Node(value);
                head.next = head;
            }
            else
            {
                Node current = head;
                Node newNode = new Node(value);

                while (current.next != head)
                {
                    current = current.next;
                }

                current.next = newNode;
                newNode.next = head;
            }
        }

        public void Display()
        {
            int count = 0;
            Node currentHead = head;
            Console.WriteLine("Data entered in the list are:");

            do
            {
                Console.Write("node number {0}:", ++count);
                Console.WriteLine(currentHead.data);
                currentHead = currentHead.next;
            }
            while (currentHead != head);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            CircularLinkedList newlist = new CircularLinkedList();
            Console.WriteLine("Enter the number of nodes:");
            int nodes = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < nodes; i++)
            {
                Console.Write("Enter input {0}: ", i + 1);
                int input = Convert.ToInt32(Console.ReadLine());
                newlist.AddLast(input);
            }

            newlist.Display();
        }
    }
}
