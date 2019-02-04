using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    /// <summary>
    /// Utility class to handle string operations.
    /// </summary>
    public static class StringHandler
    {
        /// <summary>
        /// String extension method for inserting spaces before each capitalized letter.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string InsertSpaces(this string source)
        {
            if (string.IsNullOrWhiteSpace(source))
                return String.Empty;

            StringBuilder sb = new StringBuilder();

            char previous = '\0';

            foreach (char letter in source)
            {
                // Account for a space already existing before
                // capital letter. In that case, do not add another
                // space to sb.
                if (char.IsUpper(letter) && previous != ' ')
                {
                    sb.Append(" ");
                }
                sb.Append(letter);
                previous = letter;
            }
            return sb.ToString().Trim();
        }
    }
}