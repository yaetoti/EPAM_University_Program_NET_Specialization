using System.Globalization;

namespace NextBiggerTask
{
    public static class NumberExtension
    {
        /// <summary>
        /// Finds the nearest largest integer consisting of the digits of the given positive integer number; return -1 if no such number exists.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <returns>
        /// The nearest largest integer consisting of the digits  of the given positive integer; return -1 if no such number exists.
        /// </returns>
        /// <exception cref="ArgumentException">Thrown when source number is less than 0.</exception>
        public static int NextBiggerThan(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException($"Value of {nameof(number)} cannot be less zero.");
            }

            int digitCount = 0;
            int biggerIndex = -1; // Null based index of a first number that is bigger than the next one
            for (int num = number, lastDigit = 0; num > 0; num /= 10)
            {
                if (biggerIndex == -1)
                {
                    int currDigit = num % 10;
                    if (digitCount != 0 && lastDigit > currDigit)
                    {
                        biggerIndex = digitCount - 1;
                    }

                    lastDigit = currDigit;
                }

                ++digitCount;
            }

            if (biggerIndex == -1)
            {
                return -1;
            }

            int result = SwapDigits(number, biggerIndex, biggerIndex + 1);
            for (int i = 0; i < biggerIndex; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j <= biggerIndex; j++)
                {
                    int digit1 = (result / Pow(10, minIndex)) % 10;
                    int digit2 = (result / Pow(10, j)) % 10;
                    if (digit2 > digit1)
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    result = SwapDigits(result, i, minIndex);
                }
            }

            if (result <= number)
            {
                return -1;
            }

            return result;
        }

        public static int SwapDigits(int number, int pow1, int pow2)
        {
            pow1 = Pow(10, pow1);
            pow2 = Pow(10, pow2);
            int digit1 = (number / pow1) % 10;
            int digit2 = (number / pow2) % 10;

            number -= digit1 * pow1;
            number += digit2 * pow1;

            number -= digit2 * pow2;
            number += digit1 * pow2;

            return number;
        }

        public static int Pow(int number, int power)
        {
            int result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}
