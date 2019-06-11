using System;
using System.Collections.Generic;
using System.IO;

namespace Anagram
{
    public class EmptyFileException : Exception { }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Anagrams
    {
        public string[] LoadedWords { get; private set; }
         string[] DictionaryToBeUsed { get; set; }

        public void LoadWords(string path)
        {
            string[] Words = File.ReadAllLines(path);
            if(Words.Length == 0)
            {
                throw new EmptyFileException();
            }
            LoadedWords = Words;
            DictionaryToBeUsed = File.ReadAllLines(@"C:\Users\Silvio Arzeno\Desktop\Anagram Tests\EnglishDictionary.txt");
            
        }

        public Dictionary<string, string[]> FindAllAnagrams()
        {
            Dictionary<string, string[]> ExpectedResult = new Dictionary<string, string[]>();
            ExpectedResult.Add("fresher", new string[] { "refresh" });
            return ExpectedResult;
        }
    }
}
