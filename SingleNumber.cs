public class Solution {
    public int SingleNumber(int[] nums) {

        /* 
        
        Hint 1
        Think about the XOR (^) operator's property.
        Question 
        Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.

You must implement a solution with a linear runtime complexity and use only constant extra space.
        */

    int result = 0;
    foreach(int num in nums)
        {
            result = result ^ num;
        }

        return result;
    }
}