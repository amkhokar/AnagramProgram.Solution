using System;
using System.Collections.Generic;

namespace Anagram 
{
    public class AnagramProgram
    {
        private static List<string> _anagramList = new List<string>();
        private static string _inputWord = ""; 
        private static List<string> _inputList = new List<string>(); 
        public void SetAnagrams()
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
        public List<string> GetAnagrams()
        {
            return _anagramList; 
        }
        public void AddToInputList(string inputWord)
        {
            _inputList.Add(inputWord);
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
        public class Program
    {
        public static void Initialize()
        {
            AnagramProgram anagramz = new AnagramProgram(); 
            Console.WriteLine("Enter your word to match from: ");
            string input = Console.ReadLine(); 
            anagramz.AddToInputList(input);
            while (input != "match")
            {
                Console.WriteLine("Enter one word a time and type 'match' to check matches against original word");
                input = Console.ReadLine();          
            }         
        }
        public static void main() 
        { 
            Console.WriteLine("Welcome to Anagram Match!");  
            Initialize(); 
        }
    }  
    }
}