﻿namespace WhileStatements
{
    public static class Digits
    {
        public static ulong GetDigitsSum(ulong n)
        {
            ulong sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }

            return sum;
        }

        public static ulong GetDigitsProduct(ulong n)
        {
            if (n == 0)
            {
                return 0;
            }

            ulong prod = 1;
            while (n != 0)
            {
                prod *= n % 10;
                n /= 10;
            }

            return prod;
        }
    }
}
