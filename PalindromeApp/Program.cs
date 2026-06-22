namespace PalindromeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = string.Empty;
            while (userInput != "/exit")
            {

            Console.WriteLine("Enter a word that you want to check if it's a palindrome: ");
             userInput = Console.ReadLine();

            PalindromeDetector detector = new PalindromeDetector();

            bool result = detector.isPalindrome(userInput);


            Console.WriteLine($"{userInput} -> {result}");
            }
        }
    }
}
