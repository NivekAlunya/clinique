using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Clinique.Tools
{
    public static class StringExtention
    {
        public static string fisrtChar2uppperForEachWord(this string _string)
        {
            char[] c = _string.ToCharArray();
            for (int i = 0; i < c.Length; ++i)
                if (0 == i || !c[i - 1].isLetter())
                    c[i] = c[i].toUpper();
                else
                    c[i] = c[i].toLower();
            return new string(c);
        }

        public static bool isServiceCode(this string _string)
        {
            return new Regex(@"^[a-zA-Z0-9\-_]{5}$").IsMatch(_string);
        }

        public static bool isEmail(this string _string)
        {
            return new Regex(@"^[a-zA-Z0-9\-_\.]+@[a-zA-Z0-9\-_\.]+\.[a-zA-Z0-9\-_\.]+$").IsMatch(_string);
        }

        public static bool isEmptyOrGreaterThan(this string _string, int length)
        {
            return string.IsNullOrWhiteSpace(_string) || _string.Length > length;
        }

        public static bool isEmptyOrGreaterThanTrim(this string _string, int length)
        {
            return string.IsNullOrWhiteSpace(_string) || _string.Trim().Length > length;
        }

        public static bool isGreaterThan(this string _string, int length)
        {
            return _string.Length > length;
        }

        public static bool isLowerThan(this string _string, int length)
        {
            return _string.Length < length;
        }


    }
}
