using System;

namespace LookingForArrayElements
{
    public static class DecimalCounter
    {
        /// <summary>
        /// Searches an array of decimals for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="ranges">One-dimensional, zero-based <see cref="Array"/> of range arrays.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetDecimalsCount(decimal[]? arrayToSearch, decimal[]?[]? ranges)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (ranges is null)
            {
                throw new ArgumentNullException(nameof(ranges));
            }

            int i = 0;
            do
            {
                if (i >= ranges.Length)
                {
                    break;
                }

                if (ranges[i] is null)
                {
                    throw new ArgumentNullException(nameof(ranges));
                }

                if (ranges[i]?.Length != 0 && ranges[i]?.Length != 2)
                {
                    throw new ArgumentException("the length of one of the ranges is less or greater than 2.");
                }

                ++i;
            }
            while (true);

            int occurences = 0;
            i = 0;
            do
            {
                if (i >= arrayToSearch.Length)
                {
                    break;
                }

                int j = 0;
                do
                {
                    if (j >= ranges.Length)
                    {
                        break;
                    }

                    if (ranges[j]?.Length != 0 && arrayToSearch[i] >= ranges[j]?[0] && arrayToSearch[i] <= ranges[j]?[1])
                    {
                        ++occurences;
                        break;
                    }

                    ++j;
                }
                while (true);

                ++i;
            }
            while (true);

            return occurences;
        }

        /// <summary>
        /// Searches an array of decimals for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="ranges">One-dimensional, zero-based <see cref="Array"/> of range arrays.</param>
        /// <param name="startIndex">The zero-based starting index of the search.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetDecimalsCount(decimal[]? arrayToSearch, decimal[]?[]? ranges, int startIndex, int count)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (ranges is null)
            {
                throw new ArgumentNullException(nameof(ranges));
            }

            for (int i = 0; i < ranges.Length; ++i)
            {
                if (ranges[i] is null)
                {
                    throw new ArgumentNullException(nameof(ranges));
                }

                if (ranges[i]?.Length != 0 && ranges[i]?.Length != 2)
                {
                    throw new ArgumentException("the length of one of the ranges is less or greater than 2.");
                }
            }

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is less than zero");
            }

            if (startIndex >= arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is greater than or equal to arrayToSearch.Length");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "count is less than zero");
            }

            int endIndex = startIndex + count;
            if (endIndex > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "startIndex + count > arrayToSearch.Length");
            }

            int occurences = 0;

            for (int i = startIndex; i < endIndex; ++i)
            {
                for (int j = 0; j < ranges.Length; ++j)
                {
                    if (ranges[j]?.Length != 0 && arrayToSearch[i] >= ranges[j]?[0] && arrayToSearch[i] <= ranges[j]?[1])
                    {
                        ++occurences;
                        break;
                    }
                }
            }

            return occurences;
        }
    }
}
