namespace StackArray
{
    class STACK
    {
        int size;
        int top;
        int[] stackArr;

        public STACK(int capacity)
        {
            size= capacity;
            top = -1;
            stackArr = new int[size];
        }

        public bool isEmpty()
        {
            if (top == -1) return true;
            else return false;
        }
        public bool isFull()
        {
            if(top==size-1) return true;
            else return false;
        }
        public void push(int value)
        {
            if(isFull())
            {
                Console.WriteLine("Stack is Overflow Can't push!!!");
            }
            else
            {
                top++;
                stackArr[top] = value;
            }
        }

        public void pop()
        {
            if(isEmpty())
            {
                Console.WriteLine("Stack is Underflow Can't Pop !!!");
            }
            else
            {
                Console.WriteLine($"{stackArr[top]} is deleted");
                top--;
            }
        }

        public int peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is Empty!!");
            }
            return stackArr[top];
            
        }

        public void display()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is Empty Can't display!!");
                return;
            }
            for(int i=top; i>=0; i--)
            {
                Console.Write(stackArr[i] + " ");
            }
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            STACK stack = new STACK(5);

            stack.push(1);
            stack.push(2);
            stack.push(3);
            stack.push(4);
            stack.push(5);

            stack.display();

            stack.pop();
            stack.pop();
            stack.display();

            Console.ReadKey();
        }
    }
}
