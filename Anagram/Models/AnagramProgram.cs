using System;
using System.Collections.Generic;

namespace Anagram 
{
    public class AnagramProgram
    {
        private static List<string> _anagramList = new List<string>();
        private static string _inputWord = ""; 
        private static List<string> _inputList = new List<string>(); 

        public AnagramProgram(string word, List<string> checkList)
        {
            _inputWord = word; 
            foreach(string check in checkList)
            {
                _inputList.Add(check); 
            }

        }
        public List<string> GetAnagrams()
        {
            return _anagramList; 
        }

        public List<string> GetInputList()
        {
            return _inputList; 
        }


        public string ReturnSortedWord(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Sort(charArray);
            string sortedWord = new string(charArray);  
            return sortedWord; 
        }
        public void AnagramMatcher()
        {
            foreach(string check in _inputList)
            {
                string sortedCheck = ReturnSortedWord(check);
                string sortedWord = ReturnSortedWord(_inputWord);
                if (sortedWord == sortedCheck)
                {
                    _anagramList.Add(check); 
                }
            }
        } 

        public static void Initialize()
        {
            List<string> inputList = new List<string>(); 
            string word = ""; 
            Console.WriteLine("");
        }
    }

    public class Program
    {
        public static void main() 
        {
            Console.WriteLine("Welcome to Anagram Match!"); 
            AnagramProgram.Initialize(); 
        }
    }

}