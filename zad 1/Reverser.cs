using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists__SLL_and_DLL_
{
    class Reverser <T>
    {
        public static DoublyNode<T> Reverse(DoublyNode<T> head)
        {
            if(head == null || head.Next == null)
                return head;
            DoublyNode<T> previous = null;
            DoublyNode<T> current = head;
            while (current != null)
            {
                previous = current.Previous;
                current.Previous = current.Next;
                current.Next = previous;
                current = current.Previous;
            }
            head = previous.Previous;
            return head;
        }
    }
}
