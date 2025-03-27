namespace ProducerConsumerProblem
{
    internal class Program
    {
        static Queue<int> buffer = new Queue<int>();
        static int bufferSize = 5;
        static int itemCount = 10;

        static void Producer()
        {
            for(int i=0; i<itemCount; i++)
            {
                lock(buffer)
                {
                    while(buffer.Count>=bufferSize)
                    {
                        Console.WriteLine("buffer is full producer is waiting...");
                        Monitor.Wait(buffer);
                    }

                    buffer.Enqueue(i);
                    Console.WriteLine("Produced "+i);
                    Monitor.Pulse(buffer);
                }
                Thread.Sleep(100);
            }
        }
        static void Consumer()
        {
            for(int i=0; i<itemCount; i++)
            {
                lock(buffer)
                {
                    while (buffer.Count == 0)
                    {
                        Console.WriteLine("buffer is empty consumer waiting...");
                        Monitor.Wait(buffer);
                    }

                    int consumedItem = buffer.Dequeue();
                    Console.WriteLine("Consumed "+consumedItem);
                }
                Thread.Sleep(200);
            }
        }
        static void Main(string[] args)
        {
            Thread ProducerThread = new Thread(Producer);
            Thread ConsumerThread = new Thread(Consumer);

            ProducerThread.Start();
            ConsumerThread.Start();

            ProducerThread.Join();
            ConsumerThread.Join();

            Console.WriteLine("process is completed successfully...");

            Console.ReadKey();
        }
    }
}
