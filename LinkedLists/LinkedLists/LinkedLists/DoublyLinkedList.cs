using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class DoublyLinkedListNode
    {
        public DoublyLinkedListNode(int data)
        {
            this.data = data;
            this.prev = null;
            this.next = null;
           
        }

        public DoublyLinkedListNode prev;
        public DoublyLinkedListNode next;
        public int data;
    }


    public class DoublyLinkedList
    {
    }
}
