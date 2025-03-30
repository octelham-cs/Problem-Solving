namespace QueueArray
{
    class Queue
    {
        int front, rear;
        int size;
        int [] queueArray;

        public Queue(int capacity)
        {
            front = rear = -1;
            size = capacity;
            queueArray = new int[size];
        }

        public bool isEmpty()
        {
            if (front == -1) return true;
            else return false;
        }
        public bool isFull()
        {
            if(rear==size-1) return true;
            else return false;
        }

        public void Enqueue(int data)
        {
            if (isFull())
            {
                Console.WriteLine("Queue is Overflow Can't add new element!!!");
                return;
            }
            if(isEmpty())
            {
                front = 0;
            }
            rear++;
            queueArray[rear] = data;
            
        }

        public void Decueue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is Empty can't delete element!!");
                return;
            }
            else
            {
                Console.WriteLine($"{queueArray[front]} is Outed");
                front++;
            }
        } 
        public int Peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is Empty!");
            }
            return queueArray[front];
        }

        public void Display()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is Empty there is No Element to Display");
                return;
            }
            for(int i=front; i<=rear; i++)
            {
                    Console.Write(queueArray[i]+" ");
            }
            Console.WriteLine();
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue(5);

            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);

            q.Display();

            q.Decueue();
            q.Decueue();
            q.Display();

            Console.ReadKey();
        }
    }
}
