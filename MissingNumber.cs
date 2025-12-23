using System;
using System.Collections.Generic;
using System.Text;

    public class MissingNumber
    {

        public int missingNumber(int[] nums)
        {
            int range = nums.Length;
            int x = 0;
            int y = 0;
            //x = sum of the numbers in array
            //y = sum of the numbers in range
            //y - x = missing number
            y = (range * (range + 1)) / 2;
            for (int i = 0; i < range; i++)
            {
                x = x + nums[i];
            }
            return y - x;
        }

    }

