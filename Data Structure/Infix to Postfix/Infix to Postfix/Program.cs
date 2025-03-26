namespace Infix_to_Postfix
{
    class infixToPostfixConverter
    {
       
        public static int Peroirity(char op)
        {
            switch(op)
            {
                case '+':
                case '-': 
                    return 1;

                case '*':
                case '/':
                    return 2;

                case '^':
                    return 3;

                default:
                    return 0;

            }
        }

       

        public static string ConvertInfixToPostfix(string infix)
        {
              Stack<char> stack = new Stack<char>();
              string postfix = "";

            foreach(char ch in infix)
            {
                if(char.IsLetter(ch) || char.IsDigit(ch))
                {
                    postfix += ch;
                }

                else if(ch== '(' )
                {
                    stack.Push(ch);
                }

                else if(ch== ')' )
                {
                    while(stack.Count>0 && stack.Peek() != '(')
                    {
                        postfix += stack.Pop();
                    }
                    stack.Pop();  // to remobe '(' left pracket
                }

                else if(ch=='+' || ch == '-' || ch == '*' || ch == '/' || ch == '^'  )
                {
                    while(stack.Count>0 &&  Peroirity(stack.Peek() ) >= Peroirity(ch))
                    {
                        postfix += stack.Pop();
                    }
                    stack.Push(ch);
                }
            }
            // pop remaining operator from the stack
            while (stack.Count>0)
            {
                postfix += stack.Pop();
            }

            return postfix;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Enter infix:");
            string Infix = Console.ReadLine();

            string postfix = infixToPostfixConverter.ConvertInfixToPostfix(Infix);
            Console.WriteLine($"Postfix: {postfix}");

            Console.ReadKey();
        }
    }
}
