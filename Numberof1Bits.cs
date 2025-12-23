public class Solution {
    public int HammingWeight(int n) {
        

        BitArray b = new BitArray(new int[] {n});
        bool[] bits = new bool[b.Count];
        b.CopyTo(bits,0);
        int count = 0;
        foreach (var bit in bits)
        {
            if(bit == true)
            {
                count++;
            }
        }
        return count;
        
    }
}