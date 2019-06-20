using System;

namespace NumbersToWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class InvalidInputException : Exception { }

    public class Converter
    {
        public string ToWords(int input)
        {
            string[] Units = new string[] { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"};
            string[] Tens = new string[] { "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

            string NumberString = input.ToString();
            int NumberRank = NumberString.Length;
            int Position = 0;
            string Converted = string.Empty;
            if (NumberString == "0") return "Zero";
            while (NumberRank > 0) {
                if(NumberString[Position] == '0')
                {
                    NumberRank--;
                    continue;
                }
                switch (NumberRank)
                {
                    case 1:
                        Converted += Units[Convert.ToInt32(NumberString[Position]) - 48];
                        NumberRank--;
                        Position++;
                        break;
                    case 2:
                        Converted += Tens[(Convert.ToInt32(NumberString[Position])) - 49];
                        NumberRank--;
                        Position++;
                        break;
                    case 3:

                        Converted += Units[(Convert.ToInt32(NumberString[Position])) - 48];
                        Converted += " Hundred";
                        Position++;
                        NumberRank--;
                        break;
                    case 4:
                        Converted += Units[(Convert.ToInt32(NumberString[Position])) - 48];
                        Converted += " Thousand";
                        Position++;
                        NumberRank--;
                        break;
                    case 5:
                        Converted += Tens[(int)NumberString[Position] - 49];
                        Converted += " Thousand";
                        Position++;
                        NumberRank--;
                        break;
                    default:
                        break;


                }
            }
            return Converted;
        }
    }

}
