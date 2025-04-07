namespace QueueLinkedList
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
    class queue
    {
        
        public Node front = null;
        public Node rear = null;

        public bool isEmpty()
        {
            if (front == null) return true;
            else return false;
        }
       
        public void enqueu(int value)
        {
            Node newNode= new Node(value);
            newNode.data = value;
            if (isEmpty())
            {
                front = rear = newNode;
            }
            else 
            { 
                rear.Next= newNode;
                rear = newNode;
            }
        }
        public void dequeue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is empty there is no item to dequeue");
            }
            else
            {
                front = front.Next;
            }
        }
        public void peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Console.WriteLine($"The first item is {front.data}");
            }
        }
        public void display()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is Empty!!!");
                return;
            }
            Node current = front;
            while(current != null)
            {
                Console.Write(current.data+" ");
                current = current.Next;
            }
            Console.WriteLine();
        }
        public void search(int value)
        {
            if (isEmpty())
            {
                Console.WriteLine("There is no item to search");
            }
            
            Node current = front;
            int position = 0;
                
            while (current != null)
            {
                if (current.data == value)
                {
                   Console.WriteLine($"Found item in position {position}");
                    break;
                }
                position++;
                current = current.Next;
                

            }
            if (current == null)
            {
                Console.WriteLine($"Not Fount item {value} in queue");
            }
           
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            queue q= new queue();
            q.enqueu(1);
            q.enqueu(2);
            q.enqueu(3);

            q.display(); 

            
            
            q.search(1);
            q.search(5);
            q.search(6);

            q.dequeue();
            q.display();

            Console.Read();
        }
    }
}
