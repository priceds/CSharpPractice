using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugCode
{

    public class Node
    {
        public int data { get; set; }

        public Node next { get; set; }

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
    public class LinkedList
    {

        public Node Head = null;
        public int size = 0;
        public void AddElementToFirst(int data)
        {
            Node nodeToAdd = new Node(data);
            if(Head==null)
            {
                Head = nodeToAdd;
                size++;
            }
            else
            {
                nodeToAdd.next = Head;
                Head = nodeToAdd;
                size++;

            }

        }

        public void PrintList()
        {

            Node temp = Head;
            while(temp!=null)
            {
                Console.WriteLine("| "+temp.data+" |");
                temp = temp.next;
            }
            


        }

        public void DeleteElementFromFirst()
        {

            if (Head != null)
            {
                Head = Head.next;
                PrintList();
            }


        }


    }
}
