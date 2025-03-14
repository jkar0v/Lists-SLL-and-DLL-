namespace zad_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(42);
            list.AddLast(7);
            list.AddLast(19);
            list.AddLast(3);
            list.AddLast(88);
            list.AddLast(56);

            list = MergeSort(list);

            //podzad 1
            PrintList(list);
            Console.WriteLine();

            //podzad 2
            SearchNumber(list, 19);
            SearchNumber(list, 100);
            Console.WriteLine("\nReversed:");

            //podzad 3
            ReverseLinkedList(list);
            Console.WriteLine();

            //PART 2
            //podzad 1
            RemoveNumber(list, 42);
            Console.WriteLine("\nList1:");

            //podzad 2
            LinkedList<int> list1 = new LinkedList<int>();
            list1.AddLast(1);
            list1.AddLast(5);
            list1.AddLast(10);
            PrintList(list1);
            Console.WriteLine("\nList2:");

            LinkedList<int> list2 = new LinkedList<int>();
            list2.AddLast(2);
            list2.AddLast(6);
            list2.AddLast(12);
            PrintList(list2);
            Console.WriteLine();

            LinkedList<int> merged = Merge(list1, list2);
            Console.WriteLine("\nMerged:");
            PrintList(merged);
        }
        static void PrintList(LinkedList<int> list)
        {
            foreach (int current in list)
            {
                Console.Write(current + " -> ");
            }
            Console.Write("NULL\n");
        }
        static void SearchNumber(LinkedList<int> list, int number)
        {
            if (list.Contains(number))
            {
                Console.WriteLine($"Number {number} is in the list");
                return;
            }
            Console.WriteLine($"Number {number} is not in the list :(");
        }
        static void ReverseLinkedList(LinkedList<int> list)
        {
            LinkedList<int> reversedList = new LinkedList<int>();
            foreach (int current in list)
            {
                reversedList.AddFirst(current);
            }
            PrintList(reversedList);
        }
        static LinkedList<int> MergeSort(LinkedList<int> list)
        {
            if (list.Count <= 1)
                return list;

            LinkedList<int> left, right;
            SplitList(list, out left, out right);

            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(left, right);
        }

        static void SplitList(LinkedList<int> list, out LinkedList<int> left, out LinkedList<int> right)
        {
            left = new LinkedList<int>();
            right = new LinkedList<int>();

            if (list.Count == 0)
                return;

            LinkedListNode<int> slow = list.First;
            LinkedListNode<int> fast = list.First;

            while (fast?.Next != null && fast.Next.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            LinkedListNode<int> mid = slow;
            left = new LinkedList<int>();

            LinkedListNode<int> current = list.First;
            while (current != mid.Next)
            {
                left.AddLast(current.Value);
                current = current.Next;
            }

            right = new LinkedList<int>();
            while (current != null)
            {
                right.AddLast(current.Value);
                current = current.Next;
            }
        }

        static LinkedList<int> Merge(LinkedList<int> left, LinkedList<int> right)
        {
            LinkedList<int> result = new LinkedList<int>();

            LinkedListNode<int> leftNode = left.First;
            LinkedListNode<int> rightNode = right.First;

            while (leftNode != null && rightNode != null)
            {
                if (leftNode.Value <= rightNode.Value)
                {
                    result.AddLast(leftNode.Value);
                    leftNode = leftNode.Next;
                }
                else
                {
                    result.AddLast(rightNode.Value);
                    rightNode = rightNode.Next;
                }
            }

            while (leftNode != null)
            {
                result.AddLast(leftNode.Value);
                leftNode = leftNode.Next;
            }

            while (rightNode != null)
            {
                result.AddLast(rightNode.Value);
                rightNode = rightNode.Next;
            }

            return result;
        }
        static void RemoveNumber(LinkedList<int> list, int number)
        {
            if (list.Contains(number))
            {
                list.Remove(number);
                Console.WriteLine($"Number {number} has been removed from the list!");
                PrintList(list);
                return;
            }
            Console.WriteLine($"Number {number} is not in the list :(");
        }
    }
}
