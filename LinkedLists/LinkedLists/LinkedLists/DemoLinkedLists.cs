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

        public void AddNodeAtPosition(int data, int position)
        {
            Node node = new Node(data);
            if (position == 1)
            {
                AddNodeAtFirst(data);
            }
            else
            {
                Node previousNode = GetNodeAtPosition(position - 1);
                Node nextNode = GetNodeAtPosition(position);

                previousNode.next = node;
                node.next = nextNode;

            }
            GetAllNodesWithPointers();
        }

        public void RemoveNodeAtPosition(int nodePosition)
        {
            int lengthofLinkedList = GetLengthofLinkedList();

            if (nodePosition <= lengthofLinkedList)
            {
                Node previousNode = GetNodeAtPosition(nodePosition - 1);
                Node NextNode = GetNodeAtPosition(nodePosition + 1);

                previousNode.next = NextNode;
                GetAllNodesWithPointers();
            }
            else
            {
                Console.WriteLine("Node Position does not exists in Linked List");
            }
        }

        public void RemoveNodeFromFirst()
        {
            if (head != null)
            {
                Node tempHeadNextNode = head.next;
                head = tempHeadNextNode;

            }
        }

        public void RemoveNodeFromLast()
        {
            int lenthofLinkedList = GetLengthofLinkedList();
            Node previousNode = GetNodeAtPosition(lenthofLinkedList - 1);
            previousNode.next = null;
        }

        public void ReverseLinkedList()
        {
            Node previous = null;
            Node current = head;
            while (current != null)
            {
                Node nextTemp = current.next;
                current.next = previous;
                previous = current;
                current = nextTemp;
            }
            head = previous;

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

        public bool CheckIfNodeExists(int data, out int nodePosition)
        {
            Node node = head;
            nodePosition = -1;
            int counter = 1;
            bool nodeExists = false;

            while (node != null)
            {
                if (node.data == data)
                {
                    nodeExists = true;
                    nodePosition = counter;
                    break;
                }
                node = node.next;
                counter++;
            }
            return nodeExists;
        }

        public Node GetNodeByValueandPosition(int value, int nodePosition)
        {
            Node node = head;
            int counter = 1;

            if (nodePosition == 1 && node.data == value)
                return head;

            while (node != null)
            {
                if (node.data == value && nodePosition == counter)
                    return node;
                else
                {
                    node = node.next;
                    counter++;
                }
            }
            return null;
        }

        public Node GetPreviousNode(int value)
        {
            Node previousNode = head;
            int nodePosition;
            if (CheckIfNodeExists(value, out nodePosition))
            {
                if (nodePosition != 1)
                {
                    previousNode = GetNodeAtPosition(nodePosition - 1);
                }

            }
            else
            {
                Console.WriteLine("Node does not exist");
            }
            return previousNode;
        }

        public Node GetNextNode(int value)
        {
            Node nextNode = head;
            int nodePosition;
            if (CheckIfNodeExists(value, out nodePosition))
            {
                if (nodePosition != 1)
                {
                    nextNode = GetNodeAtPosition(nodePosition + 1);
                }

            }
            else
            {
                Console.WriteLine("Node does not exist");
            }
            return nextNode;
        }

        public Node GetNodeAtPosition(int nodePosition)
        {
            Node node = head;
            int counter = 1;

            if (nodePosition == 1)
                return head;

            while (counter <= GetLengthofLinkedList())
            {
                if (nodePosition == counter)
                    return node;
                else
                {
                    node = node.next;
                    counter++;
                }
            }
            return null;
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
