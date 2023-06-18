using System;

namespace CircularLinkedList_Q5_
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

    public class DoubleLinkedList
    {
        public static Node head;

        public DoubleLinkedList()
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

                Node current = head;
                while (current.next != head)
                {
                    current = current.next;
                }

                head = newHead;
                current.next = head;
            }
        }

        public void Delete()
        {
            if (head == null)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Node current = head;
                while (current.next != head)
                {
                    current = current.next;
                }

                current.next = head.next;
                head = head.next;
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

        public void AddByPosition(int value, int position)
        {
            int currentPosition = 0;

            if (head == null)
            {
                head = new Node(value);
                head.next = head;
            }
            else if (position == 1)
            {
                Node newHead = new Node(value);
                newHead.next = head;

                Node current = head;
                while (current.next != head)
                {
                    current = current.next;
                }

                head = newHead;
                current.next = head;
            }
            else
            {
                Node current = head;
                Node newNode = new Node(value);

                while (current.next != head)
                {
                    if (currentPosition + 2 == position)
                    {
                        newNode.next = current.next;
                        current.next = newNode;
                    }
                    current = current.next;
                    currentPosition++;
                }
            }
        }

        public void Display()
        {
            int count = 0;
            Node currentHead = head;
            Console.WriteLine("Data entered in the list are:");

            do
            {
                Console.Write("Node number {0}: ", ++count);
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
            DoubleLinkedList newlist = new DoubleLinkedList();
            newlist.AddLast(1);
            newlist.AddLast(2);
            newlist.AddLast(3);
            newlist.AddLast(4);
            newlist.AddLast(5);

            newlist.Display();

            newlist.Delete();
            Console.WriteLine("After delete:");
            newlist.Display();
        }
    }
}
