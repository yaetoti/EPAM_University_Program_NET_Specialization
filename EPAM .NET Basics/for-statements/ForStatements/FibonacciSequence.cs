namespace ForStatements
{
    public static class FibonacciSequence
    {
        public static int GetFibonacciNumber(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            int prev = 0;
            int curr = 1;
            for (int i = 2; i <= n; i++)
            {
                int temp = prev + curr;
                prev = curr;
                curr = temp;
            }

            return curr;
        }

        public static ulong GetProductOfFibonacciNumberDigits(ulong n)
        {
            if (n == 0)
            {
                return 0;
            }

            ulong prod = 1;
            for (int fibonacci = GetFibonacciNumber((int)n); fibonacci != 0; fibonacci /= 10)
            {
                prod *= (ulong)(fibonacci % 10);
            }

            return prod;
        }
    }
}
