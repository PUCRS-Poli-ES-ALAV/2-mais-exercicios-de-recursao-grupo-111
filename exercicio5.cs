using System;

namespace Program
{
    public class ExPalindrome
    {
        public static void Main()
        {
            string palavra = "arara";

            Console.WriteLine("A palavra '" + palavra + "' é palindrome? " + palindrome(palavra));
        }

        public static bool palindrome(string palavra)
        {
            if(palavra == null)
            {
                throw new Exception("Campo nulo.");
            }
            if(palavra.Length == 0 || palavra.Length == 1)
            { 
                return true;
            }
            else if(palavra[0] != palavra[palavra.Length-1]) 
            {
                return false;
            }
            else { return palindrome(palavra.Substring(1, palavra.Length - 1)); }
        }
    }
}    
