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

            Console.ReadKey();

        }
    }
}
