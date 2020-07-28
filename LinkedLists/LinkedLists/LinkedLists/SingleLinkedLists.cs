using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class SingleLinkedListNode
    {
        public SingleLinkedListNode(int data)
        {
            this.data = data;
            this.next = null;
        }

        public SingleLinkedListNode next;
        public int data;
    }

    public class SingleLinkedLists
    {
        SingleLinkedListNode head;

        public void AddSingleLinkedListNodeAtFirst(int data)
        {
            if (head == null)
            {
                head = new SingleLinkedListNode(data);
            }
            else
            {
                SingleLinkedListNode singleLinkedListNode = new SingleLinkedListNode(data);
                singleLinkedListNode.next = head;
                head = singleLinkedListNode;
            }
        }

        public void AddSingleLinkedListNodeAtLast(int data)
        {
            if (head == null)
            {
                head = new SingleLinkedListNode(data);
            }
            else
            {
                SingleLinkedListNode lastSingleLinkedListNode = GetLastSingleLinkedListNode();
                SingleLinkedListNode newSingleLinkedListNode = new SingleLinkedListNode(data);
                lastSingleLinkedListNode.next = newSingleLinkedListNode;
                newSingleLinkedListNode.next = null;
            }
        }

        public void AddSingleLinkedListNodeAtPosition(int data, int position)
        {
            SingleLinkedListNode singleLinkedListNode = new SingleLinkedListNode(data);
            if (position == 1)
            {
                AddSingleLinkedListNodeAtFirst(data);
            }
            else
            {
                SingleLinkedListNode previousSingleLinkedListNode = GetSingleLinkedListNodeAtPosition(position - 1);
                SingleLinkedListNode nextSingleLinkedListNode = GetSingleLinkedListNodeAtPosition(position);

                previousSingleLinkedListNode.next = singleLinkedListNode;
                singleLinkedListNode.next = nextSingleLinkedListNode;

            }
            GetAllSingleLinkedListNodesWithPointers();
        }

        public void RemoveSingleLinkedListNodeAtPosition(int singleLinkedListNodePosition)
        {
            int lengthofLinkedList = GetLengthofLinkedList();

            if (singleLinkedListNodePosition <= lengthofLinkedList)
            {
                SingleLinkedListNode previousSingleLinkedListNode = GetSingleLinkedListNodeAtPosition(singleLinkedListNodePosition - 1);
                SingleLinkedListNode NextSingleLinkedListNode = GetSingleLinkedListNodeAtPosition(singleLinkedListNodePosition + 1);

                previousSingleLinkedListNode.next = NextSingleLinkedListNode;
                GetAllSingleLinkedListNodesWithPointers();
            }
            else
            {
                Console.WriteLine("SingleLinkedListNode Position does not exists in Linked List");
            }
        }

        public void RemoveSingleLinkedListNodeFromFirst()
        {
            if (head != null)
            {
                SingleLinkedListNode tempHeadNextSingleLinkedListNode = head.next;
                head = tempHeadNextSingleLinkedListNode;

            }
        }

        public void RemoveSingleLinkedListNodeFromLast()
        {
            int lenthofLinkedList = GetLengthofLinkedList();
            SingleLinkedListNode previousSingleLinkedListNode = GetSingleLinkedListNodeAtPosition(lenthofLinkedList - 1);
            previousSingleLinkedListNode.next = null;
        }

        public void ReverseLinkedList()
        {
            SingleLinkedListNode previous = null;
            SingleLinkedListNode current = head;
            while (current != null)
            {
                SingleLinkedListNode nextTemp = current.next;
                current.next = previous;
                previous = current;
                current = nextTemp;
            }
            head = previous;

        }

        public void GetAllSingleLinkedListNodesWithPointers()
        {
            if (head == null)
            {
                Console.WriteLine("No singleLinkedListNodes present");
            }
            else
            {
                SingleLinkedListNode singleLinkedListNode = head;
                int counter = 1;

                while (singleLinkedListNode != null)
                {
                    Console.WriteLine("SingleLinkedListNode at position {0}: ", counter);
                    Console.WriteLine("SingleLinkedListNode Value: {0}", singleLinkedListNode.data);
                    singleLinkedListNode = singleLinkedListNode.next;
                    counter++;
                }
            }
        }

        public void GetSpecificSingleLinkedListNodeValueByPosition(int position)
        {
            if (head == null)
            {
                Console.WriteLine("No singleLinkedListNodes present");
            }
            else
            {
                SingleLinkedListNode singleLinkedListNode = head;
                int counter = 1;

                while (counter <= GetLengthofLinkedList())
                {
                    if (counter == position)
                    {
                        Console.WriteLine("SingleLinkedListNode at position {0}: ", counter);
                        Console.WriteLine("SingleLinkedListNode Value: {0}", singleLinkedListNode.data);
                    }

                    singleLinkedListNode = singleLinkedListNode.next;
                    counter++;
                }
            }
        }

        public int GetLengthofLinkedList()
        {

            if (head == null) { return 0; }

            SingleLinkedListNode singleLinkedListNode = head;
            int counter = 1;
            while (singleLinkedListNode.next != null)
            {
                singleLinkedListNode = singleLinkedListNode.next;
                counter++;
            }

            return counter;
        }

        public bool CheckIfSingleLinkedListNodeExists(int data, out int singleLinkedListNodePosition)
        {
            SingleLinkedListNode singleLinkedListNode = head;
            singleLinkedListNodePosition = -1;
            int counter = 1;
            bool singleLinkedListNodeExists = false;

            while (singleLinkedListNode != null)
            {
                if (singleLinkedListNode.data == data)
                {
                    singleLinkedListNodeExists = true;
                    singleLinkedListNodePosition = counter;
                    break;
                }
                singleLinkedListNode = singleLinkedListNode.next;
                counter++;
            }
            return singleLinkedListNodeExists;
        }

        public SingleLinkedListNode GetSingleLinkedListNodeByValueandPosition(int value, int singleLinkedListNodePosition)
        {
            SingleLinkedListNode singleLinkedListNode = head;
            int counter = 1;

            if (singleLinkedListNodePosition == 1 && singleLinkedListNode.data == value)
                return head;

            while (singleLinkedListNode != null)
            {
                if (singleLinkedListNode.data == value && singleLinkedListNodePosition == counter)
                    return singleLinkedListNode;
                else
                {
                    singleLinkedListNode = singleLinkedListNode.next;
                    counter++;
                }
            }
            return null;
        }

        public SingleLinkedListNode GetPreviousSingleLinkedListNode(int value)
        {
            SingleLinkedListNode previousSingleLinkedListNode = head;
            int singleLinkedListNodePosition;
            if (CheckIfSingleLinkedListNodeExists(value, out singleLinkedListNodePosition))
            {
                if (singleLinkedListNodePosition != 1)
                {
                    previousSingleLinkedListNode = GetSingleLinkedListNodeAtPosition(singleLinkedListNodePosition - 1);
                }

            }
            else
            {
                Console.WriteLine("SingleLinkedListNode does not exist");
            }
            return previousSingleLinkedListNode;
        }

        public SingleLinkedListNode GetNextSingleLinkedListNode(int value)
        {
            SingleLinkedListNode nextSingleLinkedListNode = head;
            int singleLinkedListNodePosition;
            if (CheckIfSingleLinkedListNodeExists(value, out singleLinkedListNodePosition))
            {
                if (singleLinkedListNodePosition != 1)
                {
                    nextSingleLinkedListNode = GetSingleLinkedListNodeAtPosition(singleLinkedListNodePosition + 1);
                }

            }
            else
            {
                Console.WriteLine("SingleLinkedListNode does not exist");
            }
            return nextSingleLinkedListNode;
        }

        public SingleLinkedListNode GetSingleLinkedListNodeAtPosition(int singleLinkedListNodePosition)
        {
            SingleLinkedListNode singleLinkedListNode = head;
            int counter = 1;

            if (singleLinkedListNodePosition == 1)
                return head;

            while (counter <= GetLengthofLinkedList())
            {
                if (singleLinkedListNodePosition == counter)
                    return singleLinkedListNode;
                else
                {
                    singleLinkedListNode = singleLinkedListNode.next;
                    counter++;
                }
            }
            return null;
        }

        private SingleLinkedListNode GetLastSingleLinkedListNode()
        {
            SingleLinkedListNode temp = head;

            while (temp.next != null)
            {
                temp = temp.next;
            }

            return temp;
        }

    }

}
