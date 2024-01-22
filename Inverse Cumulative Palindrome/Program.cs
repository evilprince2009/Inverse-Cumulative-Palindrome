using System;

namespace Inverse_Cumulative_Palindrome
{
    class Program
    {
        static void Main()
        {
            try
            {
                Calculate();
            }
            catch (Exception)
            {
                Console.WriteLine("Can't calculate result for this input.");
            }
        }

        private static void Calculate()
        {
            while (true)
            {
                Console.WriteLine("Enter Input.");
                long n = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Cumulative Palindromic number for " + n + " is " + CumulativePalindrome.GetPalindrome(n));
                Console.WriteLine();
            }
        }
    }
}
