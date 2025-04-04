namespace BubbleSortAlgorithm
{
    internal class Program
    {
        static void BubbleSort(int[] array)
        {
            int n=array.Length;

            for(int i=0; i<n-1; i++)
            {
                for(int j=0; j<n-i-1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
        static void print(int[] array)
        {
            for(int i=0; i<array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("إلهام بكرى محمد");
            Console.WriteLine("Elham Bakrey Mohammed");
            int[] numbers = { 5, 1, 6, 2, 4,7,3 };

            Console.WriteLine("Unsorted Array: ");
            print(numbers);

            Console.WriteLine("Sorted Array: ");
            BubbleSort(numbers);
            print(numbers);


            Console.ReadKey();

          

        }
    }
}
