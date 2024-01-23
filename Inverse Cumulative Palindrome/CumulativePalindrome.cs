using System;
using System.Linq;

namespace Inverse_Cumulative_Palindrome
{
    public class CumulativePalindrome
    {
        public static long[] GetPalindromeAndIteration(long input)
        {
            long desired_number = input;
            long counter = 0;
            while (!CheckPalindrome(desired_number.ToString()))
            {
                desired_number += Convert.ToInt64(Reverse(desired_number.ToString()));
                counter++;
            }

            return [desired_number, counter];
        }

        private static bool CheckPalindrome(string input)
        {
            string reversed_number = Reverse(input);
            return String.Compare(input, reversed_number, StringComparison.Ordinal) == 0;
        }

        private static string Reverse(string input)
        {
            return new string(input.Reverse().ToArray());
        }
    }
}
