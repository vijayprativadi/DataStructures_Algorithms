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
            SingleLinkedLists singleLinkedList = new SingleLinkedLists();
            
            //Adding Head
            singleLinkedList.AddSingleLinkedListNodeAtFirst(34);
            singleLinkedList.AddSingleLinkedListNodeAtFirst(77);

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
            Console.WriteLine("Getting SingleLinkedListNode By Value & Position: " + singleLinkedList.GetSingleLinkedListNodeByValueandPosition(51, 3).data);

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

            Console.ReadKey();

        }
    }
}
