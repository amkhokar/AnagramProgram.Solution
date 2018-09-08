using System;
using System.Collections.Generic;

namespace Anagram 
{
    public class AnagramProgram
    {
        private static List<string> _anagramList = new List<string>();
        
        public void AddAnagram(string word) 
        {
            _anagramList.Add(word); 
        }

        public List<string> GetAnagrams()
        {
            return _anagramList; 
        }

        public string ReturnSortedWord(string unsortedWord)
        {
            char[] charArray = unsortedWord.ToCharArray();
            Array.Sort(charArray);
            string sortedWord = new string(charArray);  
            return sortedWord; 
        }

    }
}