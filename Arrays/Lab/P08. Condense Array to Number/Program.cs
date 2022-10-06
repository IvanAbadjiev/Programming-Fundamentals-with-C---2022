using System;
using System.Linq;

namespace P08._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //read input number
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            //sum condensed number

            while (nums.Length > 1)
            {
                //save date
                int[] condensed = new int[nums.Length - 1];
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    condensed[i] = nums[i] + nums[i + 1];
                }
                nums = condensed;

            }




            Console.WriteLine(nums[0]);

        }
    }
}
