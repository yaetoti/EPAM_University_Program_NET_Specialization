namespace WhilePractice
{
    public static class Task6
    {
        /// <summary>
        /// Calculate the following sum
        /// -1/3 + 1/5 - 1/7 + ... + (-1)^n / (2 * n + 1), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double SumSequenceElements(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("n should be greater than 0.");
            }

            double sum = 0.0;
            double sign = -1;
            int i = 1;
            while (i <= n)
            {
                double term = sign / ((2 * i) + 1);
                sign *= -1;
                sum += term;
                ++i;
            }

            return sum;
        }
    }
}
