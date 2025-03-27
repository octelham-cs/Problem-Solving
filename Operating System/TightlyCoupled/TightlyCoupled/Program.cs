namespace TightlyCoupled
{
    class smartWorker
    {
        public void Work()
        {
            Console.WriteLine("Smart Worker Working...");
        }
    }
    class lazyWorker
    {
        public void Work()
        {
            Console.WriteLine("Lazy Worker Working...");
        }
    }
    class Manager
    {
        smartWorker sW;
        lazyWorker lW;

        public Manager(smartWorker sW, lazyWorker lW)
        {
            this.sW = sW;
            this.lW = lW;
        }

        public void ManageWorking()
        {
            sW.Work();
            lW.Work();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            smartWorker sW=new smartWorker();
            lazyWorker lW=new lazyWorker();
            Manager mn=new Manager(sW, lW);
            mn.ManageWorking();

            Console.ReadKey();
        }
    }
}
