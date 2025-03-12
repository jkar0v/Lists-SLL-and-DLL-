namespace zad_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.AddFirst(1);
            list.AddFirst(2);
            list.AddFirst(3);
            list.AddLast(4);
            list.AddLast(5);
            list.AddLast(6);
            list.Print();
            Console.WriteLine($"The number of elements is: {list.Count}");
            SinglyNode<int> middle = MiddleFinder<int>.FindMiddle(list.Head);
            Console.WriteLine("The middle you want me to return: " + middle.Value);
        }
    }
}
