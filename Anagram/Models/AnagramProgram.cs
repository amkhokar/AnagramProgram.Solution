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
                if (_inputWord.Length > check.Length)
                {
                    if (IsPartialMatch(_inputWord, check))
                    {
                        _anagramList.Add(check); 
                    }
                }
            }
        }
        public List<string> GetAnagrams()
        {
            return _anagramList; 
        }
        public void SetMatchWord(string matchWord)
        {
            _inputWord = matchWord; 
        }
        public string GetMatchWord()
        {
            return _inputWord;
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
        public bool IsPartialMatch(string bigWord, string littleWord)
        {
            string[] littleArray = littleWord.Split(); 
            bool IsMatch = true; 
            foreach(string letterword in littleArray)
            {
                if (!bigWord.Contains(letterword))
                {
                    return false; 
                }
            }
            return IsMatch; 
        }
    }
    public class Program
    {
        public static void Initialize()
        {
            AnagramProgram anagramz = new AnagramProgram(); 
            Console.WriteLine("Enter your word to match from: ");
            string input = Console.ReadLine(); 
            anagramz.SetMatchWord(input);
            while (input != "match")
            {
                Console.WriteLine("Enter one word a time and type 'match' to check matches against original word");
                input = Console.ReadLine();
                anagramz.AddToInputList(input);          
            }
            Console.WriteLine("\n\nThese are the matches for '" + anagramz.GetMatchWord() + "'\n");
            anagramz.SetAnagrams(); 
            List<string> newList = new List<string>(); 
            newList = anagramz.GetAnagrams();  
            foreach(string word in newList)
            {
                Console.Write(word + "\n\n");
        }
            Console.WriteLine("Thank you for playing! Press CTRL + C To Quit!!!"); 
            Initialize(); 
        }
        public static void Main() 
        { 
            Console.WriteLine("Welcome to Anagram Match!");  
            Initialize(); 
        }
    }  
}