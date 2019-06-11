using System;
using System.IO;

namespace AnagramsKatas
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class Anagram
    {
        public  class EmptyFileException : Exception { }

        public void LoadWords(string path)
        {
            string[] words = File.ReadAllLines(path);
            if(words.Length == 0)
            {
                throw new EmptyFileException();
            }
        }
    }
}
