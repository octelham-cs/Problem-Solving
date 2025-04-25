namespace BinarySearch
{
    internal class Program
    {
        static int BinSearch(int[] arr, int target)
        {
            int left = 0;
            int rigth = arr.Length - 1;

            while(left<=rigth)
            {
                int mid = (left + rigth) / 2;

                if (arr[mid] == target)
                {
                    return mid;
                }
                else if (target < arr[mid])
                {
                    rigth = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Elham Bakrey Mohamed Khesha");
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Enter the Target: ");
            int target=Convert.ToInt32(Console.ReadLine());

            int result=BinSearch(nums, target);

            Console.WriteLine(result==-1?"not found":"found in index {0}",result);

            //Console.WriteLine("إلهام بكرى محمد خيشه");
            Console.ReadKey();
        }
    }
}
