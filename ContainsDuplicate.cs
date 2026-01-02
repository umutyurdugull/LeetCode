public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        

        HashSet<int> seen = new HashSet<int>();

        //Hashset kodun internette buldum direkt aldım. Öğrenmem lazım. 
        foreach(int num in nums)
        {
            if(!seen.Add(num))
                return true;
        }
        return false;

    }
}