namespace ArrayResizeCustom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[0];
            CustomArrayResize(ref arr, 5, 6, 4, 5, 45, 62);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
        public static int[] CustomArrayResize(ref int[] array, params int[] nums)
        {
            int[] newArr = new int[array.Length + nums.Length];

            for (int i = 0; i < array.Length; i++)
            {
                newArr[i] = array[i];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                newArr[i + array.Length] = nums[i];
            }
            array = newArr;
            return array;
        }
    }
}
