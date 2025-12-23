using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

    public class FibonacciNumber
    {


        int fib(int n)
        {
            if(n == 0)
                return 0;
            if(n == 1)
                return 1;
            //Instead of using recursive functions I'm gonna use loops.
            //I'll also write the recursive solution

            int x = 0;
            int prev1 = 0, prev2 = 1;
            for(int i =2;i <= n;i++)
            {
                x = prev1 + prev2;
                prev1 = prev2;
                prev2 = x;
            }
            return x;
        }
    }

