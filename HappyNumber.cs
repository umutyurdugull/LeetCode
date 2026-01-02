public class Solution {
    public bool IsHappy(int n) {
        
        HashSet<int> seenNumbers = new HashSet<int>();
        while(n!=1 && !seenNumbers.Contains(n))
        {
            seenNumbers.Add(n);
            n = GetSumOfSquareDigits(n);
        }
        return n == 1;
    }

    private int GetSumOfSquareDigits(int n)
    {
        int sum = 0;

        while(n >0)
        {
            int digit = n % 10;
            sum += digit*digit;
            n = n / 10;

        }
        return sum;
    }
}