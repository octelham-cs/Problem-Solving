using System.Linq.Expressions;
using System.Threading.Channels;

namespace BalancedParances
{
    class STACK
    {
        int size;
        int top;
        char[] stackArray;
        public STACK(int maxSize)
        {
            top = -1;
            size = maxSize;
            stackArray = new char[size];

        }
        public bool isEmpty()
        {
            if (top == -1) return true;
            else return false;
        }
        public bool isFull()
        {
            if (top == size - 1) return true;
            else return false;
        }
        public void push(char ch)
        {
            top++;
            stackArray[top] = ch;
        }
        public void pop()
        {
            if(isEmpty()) return;
            top--;
        }

        public char peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("stack is underflow!!!");
                
            }
            
            return stackArray[top];
        }
    }

    class checkBalancedParances
    {
        
        public static bool isBalanced(string expression)
        {
            STACK stack = new STACK(expression.Length);

            foreach(char ch in expression)
            {
                if(ch=='(' || ch == '{' || ch == '[' )
                {
                    stack.push(ch);
                }
                else if(ch == ')' || ch == '}' || ch == ']')
                {
                    switch(ch)
                    {
                        case ')':
                            if (stack.peek() == '(')
                                stack.pop();
                            break;

                        case '}':
                            if (stack.peek() == '{')
                                stack.pop();
                            break;

                        case ']':
                            if (stack.peek() == '[')
                                stack.pop();
                            break;

                        
                    }
                }
            }

            return stack.isEmpty();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Expression to check Balanced: ");
            string expression = Console.ReadLine();

            bool result=checkBalancedParances.isBalanced(expression);

            Console.WriteLine(result?"Balanced":"Not Balanced");

            Console.ReadKey();
        }
    }
}
