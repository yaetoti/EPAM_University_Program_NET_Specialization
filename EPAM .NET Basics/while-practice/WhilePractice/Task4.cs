namespace WhilePractice
{
    public static class Task4
    {
        /// <summary>
        /// Calculate the following sum
        /// 1/(3 * 3) + 1/(5 * 5) + 1/(7 * 7) + ... + 1/((2 * n + 1) * (2 * n + 1)), where n > 0.
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
            int i = 0;
            while (i < n)
            {
                double term = 1.0 / (((2.0 * i) + 3) * ((2.0 * i) + 3));
                sum += term;
                ++i;
            }

            return sum;
        }
    }
}
