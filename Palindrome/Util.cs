using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome
{
    public class Util
    {
        // Check for Palindrome
        public static bool IsPalindrome(string input)
        {
            string reversed = new string(input.Reverse().ToArray());
            return string.Equals(input, reversed, StringComparison.OrdinalIgnoreCase);
        }
    }
}
