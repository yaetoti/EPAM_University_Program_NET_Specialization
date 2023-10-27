namespace ForStatements
{
    public static class GeometricSequences
    {
        public static ulong GetGeometricSequenceTermsProduct(uint a, uint r, uint n)
        {
            ulong product = a;
            ulong prev = a;
            for (uint i = 1; i < n; i++)
            {
                prev *= r;
                product *= prev;
            }

            return product;
        }

        public static ulong SumGeometricSequenceTerms(uint n)
        {
            const uint a = 5;
            const uint r = 3;
            ulong sum = 0;
            ulong prev = a;
            for (uint i = 0; i < n; i++)
            {
                sum += prev;
                prev *= r;
            }

            return sum;
        }

        public static ulong CountGeometricSequenceTerms1(uint a, uint r, uint maxTerm)
        {
            ulong prev = a;
            ulong count = 0;
            for (; prev <= maxTerm; ++count)
            {
                prev *= r;
            }

            return count;
        }

        public static ulong CountGeometricSequenceTerms2(uint a, uint r, uint n, uint minTerm)
        {
            ulong count = 0;
            ulong prev = a;

            for (uint i = 0; i < n; i++)
            {
                if (prev >= minTerm)
                {
                    count++;
                }

                prev *= r;
            }

            return count;
        }
    }
}
