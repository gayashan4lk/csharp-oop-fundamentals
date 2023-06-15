using System;

namespace Stark.Common
{
    public static class StringHandler
    {
        // public static string InsertSpaces (string text)

        /// <summary>
        /// Inserts spaces before each capital letter in a string
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string InsertSpaces (this string text)
        {
            string result = String.Empty;

            if (!String.IsNullOrWhiteSpace(text))
            {
                foreach (char c in text)
                {
                    if (char.IsUpper(c) && text.IndexOf(c) != 0)
                    {
                        result = result.Trim();
                        result += " ";
                    }
                    result += c;
                }
            }
            return result;
        }
    }
}
