using System;

namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 4, 3, 1, 5, 6, }; int min = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }
            Console.WriteLine(min);

        }
    }
}

