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
            singleLinkedList.AddNodeAtFirst(34);
            singleLinkedList.AddNodeAtFirst(77);

            //Adding Tail
            singleLinkedList.AddNodeAtLast(51);

            //Print Specific Node
            singleLinkedList.GetSpecificNodeValueByPosition(3);

            //Print Linked List
            singleLinkedList.GetAllNodesWithPointers();

            //Find Length of Linked List
            Console.WriteLine("Length of the Linked List is {0}", singleLinkedList.GetLengthofLinkedList());

            //Check If node exists 
            int nodePosition;
            bool nodeExists = singleLinkedList.CheckIfNodeExists(51, out nodePosition);
            Console.WriteLine(nodeExists ? "Node exists at " + nodePosition : "Node does not exists");

            //Get Node By Value & Position
            Console.WriteLine("Getting Node By Value & Position: " + singleLinkedList.GetNodeByValueandPosition(51, 3).data);

            //Get Node By Position
            Console.WriteLine("Getting Node By Position: " + singleLinkedList.GetNodeAtPosition(3).data);

            //Get Previous Node
            Console.WriteLine("Previous Node is: " + singleLinkedList.GetPreviousNode(34).data);

            //Get Next Node
            Console.WriteLine("Next Node is: " + singleLinkedList.GetNextNode(34).data);

            //Add a Node By Value & Position
            singleLinkedList.AddNodeAtPosition(21, 2);

            //Remove Node By Position
            Console.WriteLine("After Removing Node by Position: ");
            singleLinkedList.RemoveNodeAtPosition(2);

            //Remove First Node
            singleLinkedList.RemoveNodeFromFirst();
            
            //Remove Last Node
            singleLinkedList.RemoveNodeFromLast();

            //Reverse Linked List
            singleLinkedList.ReverseLinkedList();

            Console.ReadKey();

        }
    }
}
