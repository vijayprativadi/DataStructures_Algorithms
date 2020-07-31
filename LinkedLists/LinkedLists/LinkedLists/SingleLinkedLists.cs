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

        public void FindDuplicates()
        {
            SingleLinkedListNode temp1 = head;
            SingleLinkedListNode temp2 = head.next;
            while (temp1 != null)
            {
                while (temp2 != null)
                {
                    if (temp2.data == temp1.data)
                    {
                        Console.WriteLine("Duplicate Value is: " + temp1.data);
                    }
                    temp2 = temp2.next;
                }
                temp1 = temp1.next;

                if (temp1 != null)
                {
                    temp2 = temp1.next;
                }
            }
        }

        public void OddEvenLinkedList()
        {
            SingleLinkedListNode odd = head;
            SingleLinkedListNode oddHead = head;
            
            SingleLinkedListNode even = head.next;
            SingleLinkedListNode evenHead = head.next;

            while (even != null && even.next != null)
            {

                odd.next = odd.next.next;
                even.next = even.next.next;
                odd = odd.next;
                even = even.next;
            }
            odd.next = evenHead;
        }

        public void IsLinkedListPalindrome()
        {
            int lenthofLinkedList = GetLengthofLinkedList();
            string result = "It's a Palindrome";
            int counter = 1;
            for (int i = lenthofLinkedList; i > (lenthofLinkedList / 2); i--)
            {
                SingleLinkedListNode tempLastNode = GetSingleLinkedListNodeAtPosition(i);
                SingleLinkedListNode tempfirstNode = GetSingleLinkedListNodeAtPosition(counter);
                if (tempLastNode.data != tempfirstNode.data)
                {
                    result = "Not a Palindrome";
                }
                counter++;
            }
            Console.WriteLine(result);
            
        }

        public void RotateLinkedList(int k)
        {
            //SingleLinkedListNode newhead = head;
            SingleLinkedListNode temp = head;

            while (k > 0)
            {
                SingleLinkedListNode lastNode = head;
                while (lastNode.next.next != null)
                {
                    lastNode = lastNode.next;
                }


                //Last Node 
                temp = head;
                head = lastNode.next;
                head.next = temp;
                lastNode.next = null;

                //SingleLinkedListNode temp = Intialhead;
                //while (temp != null)
                //{
                //    temp = temp;
                //}
                //tempHead.next = head;
                //tempHead = lastNode;

                k--;
            }
            GetAllSingleLinkedListNodesWithPointers();
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

        //public void ReverseLinkedListGroupBySize(int k)
        //{
        //    int lenthofLinkedList = GetLengthofLinkedList();
        //    int counter = lenthofLinkedList;
        //    int numberofelementsInThisGroup = k;
        //    int numberofGroups = 0;
        //    int counterforgroup = 1;

        //    while (counter >= k)
        //    {
        //        numberofGroups++;
        //        counter = counter - k;
        //    }

        //    if (counter < k && counter != 0)
        //    {
        //        numberofGroups++;
        //        counter = 0;
        //    }

        //    while (counterforgroup <= numberofGroups)
        //    {
        //        //DO Something


        //        numberofelementsInThisGroup = lenthofLinkedList - numberofelementsInThisGroup;
        //        counterforgroup++;
        //    }
        //}

        public void MergeTwoLinkedList(SingleLinkedLists firstLinkedList, SingleLinkedLists secondLinkedList)
        {
            SingleLinkedLists mergedLinkedList = new SingleLinkedLists();
            SingleLinkedListNode tempFirstLinkedList = firstLinkedList.head;
            SingleLinkedListNode tempSecondLinkedList = secondLinkedList.head;

            //Creating temp
            while (tempFirstLinkedList != null && tempSecondLinkedList != null)
            {
                //Do Something and Insert into Final MergeLinkedList
                if (tempFirstLinkedList.data <= tempSecondLinkedList.data)
                {
                    //Head
                    mergedLinkedList.AddSingleLinkedListNodeAtLast(tempFirstLinkedList.data);
                    mergedLinkedList.AddSingleLinkedListNodeAtLast(tempSecondLinkedList.data);
                }
                else if (tempSecondLinkedList.data <= tempFirstLinkedList.data)
                {
                    //Head
                    mergedLinkedList.AddSingleLinkedListNodeAtLast(tempSecondLinkedList.data);
                    mergedLinkedList.AddSingleLinkedListNodeAtLast(tempFirstLinkedList.data);
                }

                tempFirstLinkedList = tempFirstLinkedList.next;
                tempSecondLinkedList = tempSecondLinkedList.next;
            }

            #region Commented Code
            //while (tempFirstLinkedList != null)
            //{
            //    mergedLinkedList.AddSingleLinkedListNodeAtLast(tempFirstLinkedList.data);
            //    tempFirstLinkedList = tempFirstLinkedList.next;
            //}

            //while (tempSecondLinkedList != null)
            //{
            //    mergedLinkedList.AddSingleLinkedListNodeAtLast(tempSecondLinkedList.data);
            //    tempSecondLinkedList = tempSecondLinkedList.next;
            //}

            //SingleLinkedListNode temp1 = mergedLinkedList.head;
            //while (mergedLinkedList != null)
            //{
            //    SingleLinkedListNode temp2 = temp1.next;
            //    SingleLinkedListNode temp3 = null;
            //    if (temp2 != null && temp1.data > temp2.data)
            //    {
            //        temp3 = temp2;
            //        temp2 = temp1;
            //        temp1 = temp3;
            //    }
            //    temp1 = temp1.next;
            //}

            //mergedLinkedList.GetAllSingleLinkedListNodesWithPointers();
            #endregion Commented Code
        }

        //public void ReverseNodesInLinkedList(int k)
        //{
        //    int i = 1;
        //    int j = k;
        //    while (j <= GetLengthofLinkedList())
        //    {
        //        ReverseNodes(i, j);
        //        i = i + k;
        //        j = j + k;
        //    }
        //}

        //private void ReverseNodes(int i, int j)
        //{
        //    while(i!=j && i<j)
        //    {
        //        SingleLinkedListNode firstNode = GetSingleLinkedListNodeAtPosition(i);
        //        SingleLinkedListNode secondNode = GetSingleLinkedListNodeAtPosition(j);

        //        SingleLinkedListNode firstNextNode = firstNode.next;
        //        SingleLinkedListNode secondNextNode = secondNode.next;

        //        SingleLinkedListNode temp;

        //        temp = secondNode;
        //        secondNode = firstNode;
        //        firstNode = temp;
        //        SingleLinkedListNode t1 = head;
        //        firstNode.next = firstNextNode;
        //        secondNode.next = secondNextNode;
        //        SingleLinkedListNode t2 = head;
        //        i = i + 1;
        //        j = j - 1;
        //    }

        //    return;
        //}

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
