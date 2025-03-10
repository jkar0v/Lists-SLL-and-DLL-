using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists__SLL_and_DLL_
{
    class DoublyLinkedList<T>
    {
        internal DoublyNode<T> Head { get; set; }
        internal DoublyNode<T> Tail { get; set; }

        internal DoublyLinkedList()
        {
            Head = null;
            Tail = null;
        }

        internal void AddFirst(T data)
        {
            DoublyNode<T> newNode = new DoublyNode<T>(data);
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head.Previous = newNode;
                Head = newNode;
            }
        }
        internal void AddLast(T data)
        {
            DoublyNode<T> newNode = new DoublyNode<T>(data);
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                newNode.Previous = Tail;
                Tail = newNode;
            }
        }
        internal void Print()
        {
            DoublyNode<T> current = Head;
            while (current != null)
            {
                Console.Write(current.Data + " <-> ");
                current = current.Next;
            }
            Console.WriteLine("NULL");
        }
    }
}
