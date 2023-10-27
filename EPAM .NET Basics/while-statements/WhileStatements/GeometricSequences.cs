namespace WhileStatements
{
    public static class GeometricSequences
    {
        public static uint SumGeometricSequenceTerms1(uint a, uint r, uint n)
        {
            uint sum = 0;
            uint i = 0;

            while (i < n)
            {
                uint j = 0;
                uint rpow = 1;
                while (j < i)
                {
                    rpow *= r;
                    ++j;
                }

                sum += a * rpow;
                ++i;
            }

            return sum;
        }

        public static uint SumGeometricSequenceTerms2(uint n)
        {
            const uint firstTerm = 13;
            const uint ratio = 3;
            uint sum = 0;
            uint i = 0;

            while (i < n)
            {
                uint j = 0;
                uint rpow = 1;
                while (j < i)
                {
                    rpow *= ratio;
                    ++j;
                }

                sum += firstTerm * rpow;
                ++i;
            }

            return sum;
        }

        public static uint CountGeometricSequenceTerms3(uint a, uint r, uint maxTerm)
        {
            uint count = 0;
            uint term = a;
            while (term <= maxTerm)
            {
                term *= r;
                ++count;
            }

            return count;
        }

        public static uint CountGeometricSequenceTerms4(uint a, uint r, uint n, uint minTerm)
        {
            uint count = 0;
            for (uint i = 0; i < n; i++)
            {
                uint j = 0;
                uint rpow = 1;
                while (j < i)
                {
                    rpow *= r;
                    ++j;
                }

                if (a * rpow >= minTerm)
                {
                    ++count;
                }
            }

            return count;
        }
    }
}
