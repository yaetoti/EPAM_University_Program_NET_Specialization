using System;
using System.Collections.Generic;

namespace Extension
{
    public static class MyExtension
    {
        /// <summary>
        /// Mehod that return sum of  'n' digit
        /// </summary>        
        /// <param name="n">Element parameter</param>
        /// <returns>Integer value</returns>
        public static int SummaDigit(this int n)
        {
            int result = 0;
            n = Math.Abs(n);

            while (n > 0)
            {
                result += n % 10;
                n /= 10;
            }
            return result;
        }
       
        /// <summary>
        /// Method that return sum of 'n' element and reverse of 'n'
        /// </summary>
        /// <param name="n">Element parameter</param>
        /// <returns>Ulong value</returns>
        public static ulong SummaWithReverse(this uint n)
        {
            char[] charArray = n.ToString().ToCharArray();
            Array.Reverse(charArray);
            return n + uint.Parse(new string(charArray));
        }
       
        /// <summary>
        /// Method that count amount of elements in string , which are not letters of the latin alphabet.
        /// </summary>
        /// <param name="str">String parameter</param>
        /// <returns>Integer value</returns>
        public static int CountNotLetter(this string str)
        {
            int result = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsLetter(str, i) || str[i] > 127)
                {
                    result++;
                }
            }

            return result;
        }

      
        /// <summary>
        /// Method that checks whether day is weekend or not 
        /// </summary>
        /// <param name="day">DayOfWeek parameter</param>
        /// <returns>Bool value</returns>
        public static bool IsDayOff(this DayOfWeek day)
        {
            return day == DayOfWeek.Saturday || day == DayOfWeek.Sunday;
        }

       
        /// <summary>
        /// Method that return positive ,even  element from collection 
        /// </summary>
        /// <param name="numbers">Collection of elements</param>
        /// <returns>IEnumerable -int collection  </returns>
        public static IEnumerable<int> EvenPositiveElements(this IEnumerable<int> numbers)
        {
            List<int> result = new List<int>();
            foreach (int n in numbers)
            {
                if (n > 0 && (n & 1) == 0)
                {
                    result.Add(n);
                }
            }

            return result;
        }
    }
}
