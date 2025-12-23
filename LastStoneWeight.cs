
public class Solution {
    public int LastStoneWeight(int[] stones) {
        
        List<int> stonesL = stones.ToList();
        
        while(stonesL.Count > 1)
        {
            stonesL.Sort();
            
            int max1 = stonesL[stonesL.Count - 1]; 
            int max2 = stonesL[stonesL.Count - 2];
            
            stonesL.RemoveAt(stonesL.Count - 1);
            
            stonesL.RemoveAt(stonesL.Count - 1); 

            if(max1 != max2)
            {
                int left = max1 - max2;
                stonesL.Add(left);
            }
        }
        
        return stonesL.Count == 0 ? 0 : stonesL[0];
    }
}