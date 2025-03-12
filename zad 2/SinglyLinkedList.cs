using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2
{
    class SinglyLinkedList <T>
    {
        internal SinglyNode<T> Head { get; set; }
        internal SinglyNode<T> Tail { get; set; }
        internal int Count { get; set; }
        public SinglyLinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        public void AddFirst(T value)
        {
            SinglyNode<T> newNode = new SinglyNode<T>(value);
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }
            Count++;
        }
        public void AddLast(T value)
        {
            SinglyNode<T> newNode = new SinglyNode<T>(value);
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
            }
            Count++;
        }
        public void Print()
        {
            SinglyNode<T> current = Head;
            while (current != null)
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
