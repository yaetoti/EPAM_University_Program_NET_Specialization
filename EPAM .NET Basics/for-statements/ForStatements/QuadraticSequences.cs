namespace ForStatements
{
    public static class QuadraticSequences
    {
        public static uint CountQuadraticSequenceTerms(long a, long b, long c, long maxTerm)
        {
            uint count = 0;
            for (long term = c; term <= maxTerm;)
            {
                ++count;
                term = (a * count * count) + (b * count) + c;
            }

            if (count > 0)
            {
                return count - 1;
            }
            else
            {
                return 0;
            }
        }

        public static ulong GetQuadraticSequenceTermsProduct1(uint count)
        {
            const ulong a = 7;
            const ulong b = 4;
            const ulong c = 2;
            ulong prod = 1;
            for (; count > 0; --count)
            {
                prod *= (a * count * count) + (b * count) + c;
            }

            return prod;
        }

        public static ulong GetQuadraticSequenceProduct2(long a, long b, long c, long startN, long count)
        {
            ulong prod = 1;
            for (count += startN - 1; count >= startN; --count)
            {
                prod *= (ulong)((a * count * count) + (b * count) + c);
            }

            return prod;
        }
    }
}
