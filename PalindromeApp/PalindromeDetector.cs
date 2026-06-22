using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeApp
{
    internal class PalindromeDetector
    {
        private string Reverse(string userInput)
        {
            string reversedText = "";

            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                reversedText = reversedText + userInput[i];
            }

            return reversedText;
        }

        public bool isPalindrome(string potentialPalindrome) {
            string reversedText = Reverse(potentialPalindrome);

            if (reversedText == potentialPalindrome)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
