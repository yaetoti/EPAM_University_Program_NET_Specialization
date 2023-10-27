using System;

namespace Function
{
    public enum SortOrder { Ascending, Descending }
    public static class Function
    {
        public static bool IsSorted(int[] array, SortOrder order)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            for (int i = 0; i < array.Length - 1; ++i)
            {
                if (order == SortOrder.Ascending && array[i] > array[i + 1])
                {
                    return false;
                }
                else if (order == SortOrder.Descending && array[i] < array[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        public static void Transform(int[] array, SortOrder order)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (!IsSorted(array, order))
            {
                return;
            }

            for (int i = 0; i < array.Length; ++i)
            {
                array[i] += i;
            }
        }

        public static double MultArithmeticElements(double a, double t, int n)
        {
            double result = a;

            for (int i = 1; i < n; ++i)
            {
                result *= a + t * i;
            }

            return result;
        }

        public static double SumGeometricElements(double a, double t, double alim)
        {
            double result = 0, temp = a;

            while (temp > alim)
            {
                result += temp;
                temp *= t;
            }

            return result;
        }
    }
}
