using System;

namespace PalindromeApp
{
    public class PalindromeChecker
    {
        public bool IsPalindrome(string word)
        {
            // Eliminar espacios y convertir a minúsculas
            string processedWord = word.Replace(" ", "").ToLower();
            
            // Comparar la palabra original con su reverso
            char[] charArray = processedWord.ToCharArray();
            Array.Reverse(charArray);
            string reversedWord = new string(charArray);

            return processedWord == reversedWord;
        }
    }
}
