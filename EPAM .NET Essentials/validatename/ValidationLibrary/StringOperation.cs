
using System;
using System.Text;

namespace ValidationLibrary
{
    public static class StringOperation
    {
        public static string GetValidName(string nameToValidate)
        {
            if (string.IsNullOrEmpty(nameToValidate))
            {
                throw new ArgumentException("Input string is missing or zero-length.");
            }

            StringBuilder stringBuilder = new StringBuilder();
            bool newWord = true;
            foreach (char c in nameToValidate)
            {
                if (stringBuilder.Length >= 50)
                {
                    break;
                }

                if ((char.IsLetter(c) && c < 128) || c == ' ')
                {
                    if (c == ' ')
                    {
                        if (stringBuilder.Length > 0 && stringBuilder[stringBuilder.Length - 1] != ' ')
                        {
                            stringBuilder.Append(c);
                        }
                        newWord = true;
                    }
                    else
                    {
                        if (newWord)
                        {
                            stringBuilder.Append(char.ToUpper(c));
                            newWord = false;
                        }
                        else
                        {
                            stringBuilder.Append(char.ToLower(c));
                        }
                    }
                }
            }

            string result = stringBuilder.ToString().Trim();
            if (result.Length == 0)
            {
                throw new ArgumentException("Output string is empty.");
            }

            return result;
        }
    }
}