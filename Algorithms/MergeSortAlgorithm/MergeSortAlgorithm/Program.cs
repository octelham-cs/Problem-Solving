namespace MergeSortAlgorithm
{
    internal class Program
    {
        static void MergeSort(int[] arr)
        {
            if (arr.Length <= 1) return;

            int mid = arr.Length / 2;

            int[] left = new int[mid];
            int[] right=new int[arr.Length-mid];

            for(int i=0; i<left.Length; i++)
            {
                left[i] = arr[i];
            }

            for(int i=mid; i<arr.Length; i++)
            {
                right[i-mid]= arr[i];
            }

            MergeSort(left);
            MergeSort(right);
            Merge(arr, left, right);

        }
        static void Merge(int[] arr, int[] left, int[] right)
        {
            int i = 0; int j = 0; int k = 0;

            while(i<left.Length && j < right.Length)
            {
                if (left[i]<right[j])
                {
                    arr[k] = left[i];
                    i++;   k++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;   k++;
                }
            }
            // اضافه المتبقى من اليسار طالما اليمين خلص
            while (i < left.Length)
            {
                arr[k] = left[i];
                i++;       k++;
            }
            // اضافه المتبقى من اليمين طالما اليسار خلص
            while (j < right.Length)
            {
                arr[k] = right[j];
                j++; k++;
            }
        }
        static void print(int[] arr)
        {
            for(int i=0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+ " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("إلهام بكرى محمد");
            Console.WriteLine("Elham Bakrey Mohammed");
            Console.WriteLine("Unsorted Array: ");
            int[] numbers = { 2, 6, 1, 3, 8, 4, 5, 7 };
            print(numbers);

            Console.WriteLine("Sorted Array: ");
            MergeSort(numbers);
            print(numbers);

           
            Console.ReadKey();

        }
    }
}
