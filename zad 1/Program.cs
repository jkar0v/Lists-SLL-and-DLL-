namespace Lists__SLL_and_DLL_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();
            list.AddFirst(1);
            list.AddFirst(2);
            list.AddFirst(3);
            list.AddFirst(4);

            DoublyNode<int> head = list.Head;
            list.Print();
            Console.WriteLine();
            list.Head = Reverser<int>.Reverse(head);
            list.Print();
        }
    }
}
