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
            DemoLinkedLists demoLinkedList = new DemoLinkedLists();
            
            //Adding Head
            demoLinkedList.AddNodeAtFirst(34);
            demoLinkedList.AddNodeAtFirst(77);

            //Adding Tail
            demoLinkedList.AddNodeAtLast(51);

            //Print Specific Node
            demoLinkedList.GetSpecificNodeValueByPosition(3);

            //Print Linked List
            demoLinkedList.GetAllNodesWithPointers();

            //Find Length of Linked List
            Console.WriteLine("Length of the Linked List is {0}", demoLinkedList.GetLengthofLinkedList());

            //Check If node exists 
            int nodePosition;
            bool nodeExists = demoLinkedList.CheckIfNodeExists(51, out nodePosition);
            Console.WriteLine(nodeExists ? "Node exists at " + nodePosition : "Node does not exists");

            //Get Node By Value & Position
            Console.WriteLine("Getting Node By Value & Position: " + demoLinkedList.GetNodeByValueandPosition(51, 3).data);

            //Get Node By Position
            Console.WriteLine("Getting Node By Position: " + demoLinkedList.GetNodeAtPosition(3).data);

            //Get Previous Node
            Console.WriteLine("Previous Node is: " + demoLinkedList.GetPreviousNode(34).data);

            //Get Next Node
            Console.WriteLine("Next Node is: " + demoLinkedList.GetNextNode(34).data);

            //Add a Node By Value & Position
            demoLinkedList.AddNodeAtPosition(21, 2);

            //Remove Node By Position
            Console.WriteLine("After Removing Node by Position: ");
            demoLinkedList.RemoveNodeAtPosition(2);

            //Remove First Node
            demoLinkedList.RemoveNodeFromFirst();
            
            //Remove Last Node
            demoLinkedList.RemoveNodeFromLast();

            //Reverse Linked List
            demoLinkedList.ReverseLinkedList();

            Console.ReadKey();

        }
    }
}
