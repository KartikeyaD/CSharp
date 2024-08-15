using System;

namespace Project2
{
    public class BaseConverter
    {
        public static string ToBase13(int num)
        {
            const string base13Chars = "0123456789ABC";
            string result = string.Empty;
            while (num > 0)
            {
                result = base13Chars[num % 13] + result;
                num /= 13;
            }
            return string.IsNullOrEmpty(result) ? "0" : result;
        }

        public static int FromBase13(string str)
        {
            int result = 0;
            int value = 0;
            foreach (char c in str)
            {
                if (c >= '0' && c <= '9')
                {
                    value = c - '0';
                }
                else if (c >= 'A' && c <= 'C')
                {
                    value = c - 'A' + 10;
                }
                result = result * 13 + value;
            }
            return result;
        }
    }
}
