namespace SelectionSort
{
    internal class Program
    {
        static void Sort(int[] arr)
        {
            int n = arr.Length;

            for(int i=0; i<n-1; i++)
            {
                int minIndex = i;

                for(int j=i+1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }
        }

        static void print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Elham Bakrey Mohammed");
            Console.WriteLine("إلهام بكرى محمد");
            int[] Array = { 3, 90, 1, 6, 2, 5 };

            Console.WriteLine("Array Before Sorted: ");
            print(Array);

            Console.WriteLine("Array After Sorted: ");
            Sort(Array);
            print(Array);


            Console.ReadKey();

        }
    }
}
