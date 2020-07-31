using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Single Linked List

            SingleLinkedLists singleLinkedList = new SingleLinkedLists();

            //Adding Head
            singleLinkedList.AddSingleLinkedListNodeAtFirst(34);
            singleLinkedList.AddSingleLinkedListNodeAtFirst(77);
            singleLinkedList.AddSingleLinkedListNodeAtLast(45);

            //Adding Tail
            singleLinkedList.AddSingleLinkedListNodeAtLast(51);

            //Print Specific SingleLinkedListNode
            singleLinkedList.GetSpecificSingleLinkedListNodeValueByPosition(3);

            //Print Linked List
            singleLinkedList.GetAllSingleLinkedListNodesWithPointers();

            //Find Length of Linked List
            Console.WriteLine("Length of the Linked List is {0}", singleLinkedList.GetLengthofLinkedList());

            //Check If singleLinkedListNode exists 
            int singleLinkedListNodePosition;
            bool singleLinkedListNodeExists = singleLinkedList.CheckIfSingleLinkedListNodeExists(51, out singleLinkedListNodePosition);
            Console.WriteLine(singleLinkedListNodeExists ? "SingleLinkedListNode exists at " + singleLinkedListNodePosition : "SingleLinkedListNode does not exists");

            //Get SingleLinkedListNode By Value & Position
            Console.WriteLine("Getting SingleLinkedListNode By Value & Position: " + singleLinkedList.GetSingleLinkedListNodeByValueandPosition(51, 4).data);

            //Get SingleLinkedListNode By Position
            Console.WriteLine("Getting SingleLinkedListNode By Position: " + singleLinkedList.GetSingleLinkedListNodeAtPosition(3).data);

            //Get Previous SingleLinkedListNode
            Console.WriteLine("Previous SingleLinkedListNode is: " + singleLinkedList.GetPreviousSingleLinkedListNode(34).data);

            //Get Next SingleLinkedListNode
            Console.WriteLine("Next SingleLinkedListNode is: " + singleLinkedList.GetNextSingleLinkedListNode(34).data);

            //Add a SingleLinkedListNode By Value & Position
            singleLinkedList.AddSingleLinkedListNodeAtPosition(21, 2);

            //Remove SingleLinkedListNode By Position
            Console.WriteLine("After Removing SingleLinkedListNode by Position: ");
            singleLinkedList.RemoveSingleLinkedListNodeAtPosition(2);

            //Remove First SingleLinkedListNode
            singleLinkedList.RemoveSingleLinkedListNodeFromFirst();

            //Remove Last SingleLinkedListNode
            singleLinkedList.RemoveSingleLinkedListNodeFromLast();

            //Reverse Linked List
            singleLinkedList.ReverseLinkedList();

            //Console.WriteLine("************** BEFORE *************");
            //singleLinkedList.GetAllSingleLinkedListNodesWithPointers();
            //singleLinkedList.ReverseNodesInLinkedList(2);
            //Console.WriteLine("************** AFTER *************");
            //singleLinkedList.GetAllSingleLinkedListNodesWithPointers();
            //singleLinkedList.ReverseLinkedListGroupBySize(3);

            SingleLinkedLists firstLinkedList = new SingleLinkedLists();

            //Head
            firstLinkedList.AddSingleLinkedListNodeAtFirst(1);
            firstLinkedList.AddSingleLinkedListNodeAtLast(2);
            //Tail
            firstLinkedList.AddSingleLinkedListNodeAtLast(4);

            SingleLinkedLists secondLinkedList = new SingleLinkedLists();

            //Head
            secondLinkedList.AddSingleLinkedListNodeAtFirst(1);
            secondLinkedList.AddSingleLinkedListNodeAtLast(3);
            //Tail
            secondLinkedList.AddSingleLinkedListNodeAtLast(4);

            singleLinkedList.MergeTwoLinkedList(firstLinkedList, secondLinkedList);

            SingleLinkedLists singleLinkedListForRemovingDuplicates = new SingleLinkedLists();

            //Adding Head
            singleLinkedListForRemovingDuplicates.AddSingleLinkedListNodeAtFirst(1);
            singleLinkedListForRemovingDuplicates.AddSingleLinkedListNodeAtFirst(1);
            singleLinkedListForRemovingDuplicates.AddSingleLinkedListNodeAtLast(2);

            //Adding Tail
            singleLinkedListForRemovingDuplicates.AddSingleLinkedListNodeAtLast(3);
            singleLinkedListForRemovingDuplicates.AddSingleLinkedListNodeAtLast(2);
            singleLinkedListForRemovingDuplicates.AddSingleLinkedListNodeAtLast(4);
            singleLinkedListForRemovingDuplicates.AddSingleLinkedListNodeAtLast(5);
            singleLinkedListForRemovingDuplicates.AddSingleLinkedListNodeAtLast(4);
            singleLinkedListForRemovingDuplicates.AddSingleLinkedListNodeAtLast(7);

            singleLinkedListForRemovingDuplicates.FindDuplicates();

            //Odd Even Linked List 
            SingleLinkedLists oddEvenLinkedList = new SingleLinkedLists();
            oddEvenLinkedList.AddSingleLinkedListNodeAtFirst(4);
            oddEvenLinkedList.AddSingleLinkedListNodeAtFirst(3);
            oddEvenLinkedList.AddSingleLinkedListNodeAtFirst(2);
            oddEvenLinkedList.AddSingleLinkedListNodeAtFirst(1);

            oddEvenLinkedList.OddEvenLinkedList();
            oddEvenLinkedList.GetAllSingleLinkedListNodesWithPointers();

            // Palindrome Linked List
            SingleLinkedLists palindromeLinkedList = new SingleLinkedLists();
            palindromeLinkedList.AddSingleLinkedListNodeAtFirst(1);
            palindromeLinkedList.AddSingleLinkedListNodeAtFirst(2);
            palindromeLinkedList.AddSingleLinkedListNodeAtFirst(3);
            palindromeLinkedList.AddSingleLinkedListNodeAtFirst(2);
            palindromeLinkedList.AddSingleLinkedListNodeAtFirst(1);

            palindromeLinkedList.IsLinkedListPalindrome();

            //Rotate Linked List
            SingleLinkedLists rotateLinkedList = new SingleLinkedLists();
            rotateLinkedList.AddSingleLinkedListNodeAtFirst(5);
            rotateLinkedList.AddSingleLinkedListNodeAtFirst(4);
            rotateLinkedList.AddSingleLinkedListNodeAtFirst(3);
            rotateLinkedList.AddSingleLinkedListNodeAtFirst(2);
            rotateLinkedList.AddSingleLinkedListNodeAtFirst(1);

            rotateLinkedList.RotateLinkedList(2);

            #endregion

            Console.ReadKey();

        }
    }
}
