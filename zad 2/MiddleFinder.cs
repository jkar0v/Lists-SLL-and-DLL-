using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2
{
    class MiddleFinder <T>
    {
        public static SinglyNode<T> FindMiddle(SinglyNode<T> head)
        {
            if (head == null)
                return head;
            SinglyNode<T> slow = head;
            SinglyNode<T> fast = head;
            SinglyNode<T> middleHelper = null;
            while (fast != null && fast.Next != null)
            {
                middleHelper = slow;
                slow = slow.Next;
                fast = fast.Next.Next;
            }
            if (fast == null)
                Console.WriteLine($"The middles are: {middleHelper.Value} and {slow.Value}");
            else
                Console.WriteLine($"The middle is {slow.Value}");
            return slow;
        }
    }
}
