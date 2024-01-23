using System;
using System.Linq;

namespace Inverse_Cumulative_Palindrome
{
    public class CumulativePalindrome
    {
        public static long[] GetPalindromeAndIteration(long input)
        {
            long desiredNumber = input;
            long counter = 0;
            while (!CheckPalindrome(desiredNumber.ToString()))
            {
                desiredNumber += Convert.ToInt64(Reverse(desiredNumber.ToString()));
                counter++;
            }

            return [desiredNumber, counter];
        }

        private static bool CheckPalindrome(string input)
        {
            string reversedNumber = Reverse(input);
            return String.Compare(input, reversedNumber, StringComparison.Ordinal) == 0;
        }

        private static string Reverse(string input)
        {
            return new string(input.Reverse().ToArray());
        }
    }
}
