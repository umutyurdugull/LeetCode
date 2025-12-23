using System;
using System.Collections.Generic;
using System.Text;


    public class TwoSum
    {
        public int[] Solution(int[] nums, int target)
        {

            //I didn't used hashmap because I don't know how to use hashmap in c#
            //Also in 2nd loop I started from i+1 to avoid checking same element again
            for (int i = 0;i<nums.Length;i++)
            {
                for(int j = i+1;j<nums.Length;j++)
                {
                    if(nums[i]+nums[j]==target )
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[0];
        }
    }
