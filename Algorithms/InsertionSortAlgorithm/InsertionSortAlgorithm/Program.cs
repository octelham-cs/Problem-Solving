namespace InsertionSortAlgorithm
{
    internal class Program
    {
        static void InsertionSort(int[] arr)
        {
            int n=arr.Length;
            int current;
            int j;

            for(int i=1; i<n; i++)
            {
                current = arr[i];
                j = i - 1;

                while (j >= 0 && arr[j]>current)
                {
                    arr[j+1]=arr[j];
                    j--;
                }
                arr[j + 1] = current;
            }
        }
        static void print(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+" ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Elham Bakrey Mohammed");
            Console.WriteLine("إلهام بكرى محمد خيشه");

            int[] numbers = { 4, 1, 6, 2, 5, 3, 7 };

            Console.WriteLine("Unsorted Array: ");
            print(numbers);

            Console.WriteLine("Sorted Array: ");
            InsertionSort(numbers);
            print(numbers);

            Console.ReadKey();
        }
    }
}
