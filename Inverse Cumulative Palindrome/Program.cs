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
                long result = CumulativePalindrome.GetPalindromeAndIteration(n)[0];
                long iterations = CumulativePalindrome.GetPalindromeAndIteration(n)[1];
                Console.WriteLine($"Cumulative Palindromic number for {n} is {result}, found after {iterations} iterations.");
                Console.WriteLine();
            }
        }
    }
}
