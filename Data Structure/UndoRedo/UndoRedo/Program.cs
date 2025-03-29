namespace UndoRedo
{
   class forUndoRedo
    {
        Stack<string> stack1 = new Stack<string>();
        Stack<string> UndoeRedoStack = new Stack<string>();

        public void push(string value)
        {
            stack1.Push(value);
        }
        public void undoFun()
        {
            UndoeRedoStack.Push(stack1.Pop());
        }
        public void redoFun()
        {
            stack1.Push(UndoeRedoStack.Pop());
        }

        public void display()
        {
            foreach(var i in stack1)
            {
                Console.Write(i + " ");

            }
            Console.WriteLine();
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            forUndoRedo undoRedo = new forUndoRedo();
            undoRedo.push("elham");
            undoRedo.push("bakrey");
            undoRedo.push("mohamed");
            undoRedo.display();

            undoRedo.undoFun();
            undoRedo.display();

            undoRedo.redoFun();
            undoRedo.display();



            Console.ReadKey();
        }
    }
}
