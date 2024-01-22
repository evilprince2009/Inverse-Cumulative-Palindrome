using System;
using System.Collections.Generic;
using System.Text;

namespace Inverse_Cumulative_Palindrome
{
    public class CumulativePalindrome
    {
        public static long GetPalindrome(long input)
        {
            long desiredNumber = input;

            while (!CheckPalindrome(desiredNumber.ToString()))
            {
                if (CheckPalindrome(desiredNumber.ToString()))
                {
                    return desiredNumber;
                }
                desiredNumber += Convert.ToInt64(Reverse(desiredNumber.ToString()));
            }

            return desiredNumber;
        }


        // Modification of below methods may break the code
        private static bool CheckPalindrome(string input)
        {
            string reversedNumber = Reverse(input);
            return String.Compare(input, reversedNumber, StringComparison.Ordinal) == 0;
        }

        private static string Reverse(string input)
        {
            Stack<char> container = new();
            foreach (char ch in input)
            {
                container.Push(ch);
            }

            StringBuilder result = new();
            for (int i = 0; i < input.Length; i++)
            {
                result.Append(container.Pop());
            }

            return result.ToString();
        }
    }
}