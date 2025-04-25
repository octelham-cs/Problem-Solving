namespace LinearSearch
{
    internal class Program
    {
        static int linearSearch(int[]arr , int k)
        {
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] == k)
                {
                    return i;
                }
                
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Elham Bakrey Mohamed Khesha");
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, };

            Console.WriteLine("Enter the Key you want to search: ");
            int key=int.Parse(Console.ReadLine());

            int result=linearSearch(nums, key);

            Console.WriteLine(result==-1?"not found":"found in index {0}",result);
            //Console.WriteLine("إلهام بكرى محمد خيشه");
            Console.Read();
        }
    }
}
