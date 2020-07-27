using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class Node
    {
        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }

        public Node next;
        public int data;
    }

    public class DemoLinkedLists
    {
        Node head;

        public void AddNodeAtFirst(int data)
        {
            if (head == null)
            {
                head = new Node(data);
            }
            else
            {
                Node node = new Node(data);
                node.next = head;
                head = node;
            }
        }

        public void AddNodeAtLast(int data)
        {
            if (head == null)
            {
                head = new Node(data);
            }
            else
            {
                Node lastNode = GetLastNode();
                Node newNode = new Node(data);
                lastNode.next = newNode;
                newNode.next = null;
            }
        }

        public void GetAllNodesWithPointers()
        {
            if (head == null)
            {
                Console.WriteLine("No nodes present");
            }
            else
            {
                Node node = head;
                int counter = 1;

                while (node != null)
                {
                    Console.WriteLine("Node at position {0}: ", counter);
                    Console.WriteLine("Node Value: {0}", node.data);
                    node = node.next;
                    counter++;
                }
            }
        }

        public void GetSpecificNodeValueByPosition(int position)
        {
            if (head == null)
            {
                Console.WriteLine("No nodes present");
            }
            else
            {
                Node node = head;
                int counter = 1;

                while (counter <= GetLengthofLinkedList())
                {
                    if (counter == position)
                    {
                        Console.WriteLine("Node at position {0}: ", counter);
                        Console.WriteLine("Node Value: {0}", node.data);
                    }

                    node = node.next;
                    counter++;
                }
            }
        }

        public int GetLengthofLinkedList()
        {

            if (head == null) { return 0; }

            Node node = head;
            int counter = 1;
            while (node.next != null)
            {
                node = node.next;
                counter++;
            }

            return counter;
        }

        private Node GetLastNode()
        {
            Node temp = head;

            while (temp.next != null)
            {
                temp = temp.next;
            }

            return temp;
        }

    }

}
