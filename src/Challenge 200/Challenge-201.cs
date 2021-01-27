using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_200
{
    public class Challenge_201
    {
        /// <summary>
        /// Masks the <paramref name="str"/> by transforming all but the last four characters into "#"
        /// </summary>
        /// <param name="str">The string to Mask</param>
        /// <returns>The masked string</returns>
        public string Maskify(string str)
        {
            if (str == null) return ""; // could possibly throw ArgumentNullException depending on severity

            if (str.Length <= 4) return str;

            int maskedCharCount = str.Length - 4;
            var lastFour = str.Substring(maskedCharCount);
            return $"{new string('#',maskedCharCount)}{lastFour}";
        }
    }
}
