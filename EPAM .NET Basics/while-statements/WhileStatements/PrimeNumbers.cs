namespace WhileStatements
{
    public static class PrimeNumbers
    {
        public static bool IsPrimeNumber(uint n)
        {
            if (n < 2)
            {
                return false;
            }

            uint i = 2;
            while (i * i <= n)
            {
                if (n % i == 0)
                {
                    return false;
                }

                ++i;
            }

            return true;
        }

        public static uint GetLastPrimeNumber(uint n)
        {
            uint i = n;
            while (i >= 2)
            {
                if (IsPrimeNumber(i))
                {
                    return i;
                }

                --i;
            }

            return 0;
        }

        public static uint SumLastPrimeNumbers(uint n, uint count)
        {
            uint sum = 0;
            uint primeCount = 0;
            uint i = n;
            while (i >= 2 && primeCount < count)
            {
                if (IsPrimeNumber(i))
                {
                    sum += i;
                    primeCount++;
                }

                --i;
            }

            return sum;
        }
    }
}
