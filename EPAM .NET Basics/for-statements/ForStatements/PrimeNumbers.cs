namespace ForStatements
{
    public static class PrimeNumbers
    {
        public static bool IsPrimeNumber(uint n)
        {
            if (n < 2)
            {
                return false;
            }

            for (uint i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static ulong SumDigitsOfPrimeNumbers(int start, int end)
        {
            ulong sum = 0;
            for (int i = start; i <= end; i++)
            {
                if (IsPrimeNumber((uint)i))
                {
                    ulong num = (ulong)i;
                    while (num != 0)
                    {
                        sum += num % 10;
                        num /= 10;
                    }
                }
            }

            return sum;
        }
    }
}
