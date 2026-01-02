public class Solution {
    public double MyPow(double x, int n) {
        long exp = n;
        double baseVal = x;
        double result = 1.0;

        if (exp < 0) {
            baseVal = 1.0 / baseVal;
            exp = -exp;
        }

        while (exp > 0) {
            if ((exp & 1) == 1) {
                result *= baseVal;
            }
            baseVal *= baseVal;
            exp >>= 1;
        }

        return result;
    }
}