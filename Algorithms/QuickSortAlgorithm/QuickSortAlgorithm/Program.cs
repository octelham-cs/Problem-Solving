namespace QuickSortAlgorithm
{
    internal class Program
    {
        static void QuickSort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int pivotIndex = Partition(arr, start, end);
                QuickSort(arr, start, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, end);
            }
        }
        static int Partition(int[] arr, int start, int end)
        {
            int pivot = arr[end];
            int i = start - 1;

            for (int j = start; j < end; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    // تبديل القيم
                    int temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                }
            }

            // وضع المحور (pivot) في مكانه الصحيح
            int temp2 = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = temp2;

            return i + 1;
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
                Console.WriteLine("إلهام بكرى محمد خيشه");
                Console.WriteLine("Elham Bakrey Mohammed");

                int[] numbers = { 8, 2, 6, 1, 9, 3, 5, 7, 4 };

                Console.WriteLine("Unsorted Array: ");
                print(numbers);

                Console.WriteLine("Sorted Array: ");
                QuickSort(numbers, 0, numbers.Length - 1);
                print(numbers);

                Console.ReadKey();
            }
    }
}

