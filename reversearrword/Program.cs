using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ReverseWordsNamespace
{
    class Program
    {
        string[] message = Array.Empty<string>();
        string[] newMessage = Array.Empty<string>();
        string result = string.Empty;

        public void ReverseWords(string pangram)
        {
            // Split string to array
            message = pangram.Split(' ');
            string[] newMessage = new string[message.Length];

        
            // Reverse elements in array, and elements themselves 
            for (int i = 0; i < message.Length; i++)
            {
                char[] letters = message[i].ToCharArray();
                Array.Reverse(letters);
                newMessage[i] = new string(letters);
            }

            result = String.Join(" ", newMessage);

        }
        public void PrintWords()
        {
            Console.WriteLine(result);
        }

        static void Main()
        {
            string pangram = "The quick brown fox jumps over the lazy dog";

            Program reverseWords = new Program();
            reverseWords.ReverseWords(pangram);
            reverseWords.PrintWords();
        }
    }
}