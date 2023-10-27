namespace ForStatements
{
    public static class Factorial
    {
        public static int GetFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            int fac = 1;
            for (; n > 0; --n)
            {
                fac *= n;
            }

            return fac;
        }

        public static int SumFactorialDigits(int n)
        {
            int sum = 0;

            for (int fac = GetFactorial(n); fac > 0; fac /= 10)
            {
                sum += fac % 10;
            }

            return sum;
        }
    }
}
