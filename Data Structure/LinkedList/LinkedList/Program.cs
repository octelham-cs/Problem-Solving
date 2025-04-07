using System.Net;

namespace LinkedList
{
    class Node
    {
        public int data;
        public Node Next;

        public Node(int value)
        {
            data = value;
            Next = null;
        }
    }
    class linkedList
    {
        Node Head = null;
        public void addFirst(int value)
        {
            Node newNode = new Node(value);
            newNode.Next = Head;
            Head = newNode;
        }
        public void addLast(int value)
        {
            Node newNode = new Node(value);
            if (Head == null)
            {
                Head = newNode;
                return;
            }
            Node current = Head;
            while(current.Next != null)
            {
                current=current.Next;
            }
            current.Next = newNode;
        }
        public void printList()
        {
            if(Head == null)
            {
                Console.WriteLine("List is empty there is not item to print");
                return;
            }
            Node current = Head;
            while(current != null)
            {
                Console.Write(current.data+" ");
                current = current.Next;
            }
            Console.WriteLine();
        }
        public void search(int value)
        {
            int position = 0;
            if (Head == null)
            {
                Console.WriteLine("list is empty there is no item to search");
                return;
            }
            Node current = Head;
            while (current != null)
            {
                if (current.data == value)
                {
                    Console.WriteLine($"Fount item {value} in position {position}");
                    return;
                }
                position++;
                current=current.Next;
                if (current == null)
                {
                    Console.WriteLine($"Not found item {value} in list");
                }
            }
        }
        public void deleteFirstItem()
        {
            if (Head == null)
            {
                Console.WriteLine("list is empty there is no item to delete");
                return;
            }
            Head = Head.Next;
        }

        public void deleteSpecificItem(int vlaue)
        {
            if (Head == null)
            {
                Console.WriteLine("list is empty there is not item to delete");
                return;
            }
            Node prev = Head;
            Node temp = Head.Next;
            while (temp != null)
            {
                if(temp.data == vlaue)
                {
                    prev.Next = temp.Next;
                    return;
                }
                temp = temp.Next;
                prev=prev.Next;
            }
        }
        public void deleteLastItem()
        {
            if (Head == null)
            {
                Console.WriteLine("list is empty there is not item to delete");
                return;
            }
            Node current = Head;
            while(current != null)
            {
                if (current.Next.Next == null)
                {
                    current.Next = null;
                    return;
                }
                current = current.Next;
            }
        }

    }
       
    internal class Program
    {
        static void Main(string[] args)
        {
            linkedList l=new linkedList();
            l.addLast(1);
            l.addLast(2);
            l.addLast(3);
            l.addLast(4);
            l.addFirst(5);

            l.printList();

            l.search(2);
            l.search(20);

            l.deleteFirstItem();
            l.deleteSpecificItem(3);
            l.deleteLastItem();

            l.printList();


            

            Console.Read();


        }
    }
}
