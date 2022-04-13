using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stark.Common
{
    public class StringHandler
    {
        public string InsertSpaces (string text)
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
