using System;

namespace GetMaxElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {9, -3, 100, 888, -5, 37, 26};
            var max = GetMaxElement(arr, int.MaxValue);
            var maxIndex = GetMaxElementIndex(arr);
            var sorted = BoobieSort(arr);
            Console.WriteLine($"max = {max}, index = {maxIndex}");
            //Console.WriteLine($"[{string.Join}("], [", sorted)}]);
            Console.ReadKey();
        }

        static int GetMaxElement(int[] arr, int top)
        {
            int max = int.MinValue;
            foreach (var element in arr)
            {
                if (element > max && element < top)
                {
                    max = element;
                }
            }
            return max;
        }

        static int GetMaxElementIndex(int[] arr)
        {
            int max = int.MinValue;
            int maxIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    maxIndex = i;
                    max = arr[i];
                }
            }

            return maxIndex;
        }

        static int[] BoobieSort(int[] arr)
        {
            int[] result = new int[arr.Length];
            var max = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                max = GetMaxElement(arr, max);
                result[i] = max;
            }

            return result;
        }
    }
}
