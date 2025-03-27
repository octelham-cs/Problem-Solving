namespace LooselyCoupled
{
    interface Iworker
    {
        void Work();
    }
    class smartWorker:Iworker
    {
        public void Work()
        {
            Console.WriteLine("Smart Worker Working...");
        }
    }
    class lazyWorker:Iworker
    {
        public void Work()
        {
            Console.WriteLine("Lazy Worker Working...");
        }
    }
    class extraOrdinaryWorker:Iworker
    {
        public void Work()
        {
            Console.WriteLine("Extra Ordinary Worker Working...");
        }
    }

    class Manager
    {
        Iworker iworker;
        public Manager(Iworker iworker)
        {
            this.iworker = iworker;
        }
        public void ManageWork()
        {
            this.iworker.Work();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Iworker SW = new smartWorker();
            Manager mn1 = new Manager(SW);
            mn1.ManageWork();

            Iworker LW = new lazyWorker();
            Manager mn2=new Manager(LW);
            mn2.ManageWork();

            Iworker Ex = new extraOrdinaryWorker();
            Manager mn3 = new Manager(Ex);
            mn3.ManageWork();

            Console.ReadKey();
        }
    }
}
