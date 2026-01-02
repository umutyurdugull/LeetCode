public class Solution {
    public int GetSum(int a, int b) {
        

        while(b!=0)
        {

            //1 bit sola kaydırdık
            //bunu ice'nin ilk dersinde görmüştük
            int carry = (a & b) << 1;
        
            a = a ^b ;
            b = carry;
        }

        return a;
    }
}