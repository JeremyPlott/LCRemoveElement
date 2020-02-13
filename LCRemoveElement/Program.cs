using System;

namespace LCRemoveElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 3, 2, 2, 3, 4, 5, 3, 6 };

            int val = 3;

            RemoveElement(nums, val);

            for (int num = 0; num < nums.Length; num++)
            {
                Console.WriteLine(nums[num]);
            }

            int RemoveElement(int[] nums, int val)
            {
                var arrayWriter = 0;

                for (int index = 0; index < nums.Length; index++)
                {
                    if (nums[index] == val)
                    {
                        continue;
                    }

                    nums[arrayWriter] = nums[index];
                    arrayWriter++;
                }

                return arrayWriter;
            }
        }
    }
}
