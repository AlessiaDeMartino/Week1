using System;

namespace Parola_Palindroma
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "abc";
            bool isPalindroma = true;
            for (int i=0; i<word.Length/2; i++)
            {
                if (word[i] != word[word.Length - 1])
                {
                    isPalindroma = false;
                    Console.WriteLine("Non è palindroma");
                    break;
                }
                if (isPalindroma)
                    Console.WriteLine($"{word} è una parola palindroma");
           }
        }
    }
}
