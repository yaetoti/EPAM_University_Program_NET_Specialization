namespace WhilePractice
{
    public static class Task5
    {
        /// <summary>
        /// Calculate the following product
        /// (1 + 1/(1 * 1)) * (1 + 1/(2 * 2)) * (1 + 1/(3 * 3)) * ... * (1 + 1/(n * n)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Product of elements.</returns>
        public static double GetSequenceProduct(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("n should be greater than 0.");
            }

            double product = 1.0;
            int i = 1;
            while (i <= n)
            {
                double term = 1.0 + (1.0 / ((double)i * i));
                product *= term;
                ++i;
            }

            return product;
        }
    }
}
