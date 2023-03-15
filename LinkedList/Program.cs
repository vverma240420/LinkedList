namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList Programs");

            Console.WriteLine("Welcome To Linked List");
            SimpleLinkedList linkedlist = new SimpleLinkedList();
            linkedlist.AddLast(56);
            linkedlist.AddLast(30);
            linkedlist.AddLast(70);
            linkedlist.Display();         //56 30 70

            Console.ReadLine();

        }
    }
}