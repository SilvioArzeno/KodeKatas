using System;

namespace Numbers_To_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Converter
    {

        public string ToWords(int input)
        {
            string[] Units = new string[] {" One", " Two", " Three", " Four", " Five", " Six", " Seven", " Eight", " Nine" };
            string[] Tens = new string[] { " Ten", " Twenty", " Thirty", " Fourty", " Fifty", " Sixty", " Seventy", " Eighty", " Ninety" };

            string ConvertedInput = string.Empty;
            string NumberToString = input.ToString();
            int NumberRank = NumberToString.Length;

            if(NumberToString == "0")
            {
                return "Zero";
            }
            for(int PositionBeingAnalyzed = 0; PositionBeingAnalyzed < NumberToString.Length; PositionBeingAnalyzed++)
            {
                if(NumberToString.Length > 3)
                {
                    if(PositionBeingAnalyzed % 3 == 0 && PositionBeingAnalyzed != 0)
                    {
                        ConvertedInput += " Thousand";
                    }
                }
                if(NumberToString[PositionBeingAnalyzed] == '0')
                {
                    continue;
                }

                switch (NumberRank)
                {
                    case 1:
                        ConvertedInput += Units[NumberToString[PositionBeingAnalyzed] - 49];
                        NumberRank--;
                        break;
                    case 2:
                        ConvertedInput += Tens[NumberToString[PositionBeingAnalyzed] - 49];
                        NumberRank--;
                        break;
                    case 3:
                        ConvertedInput += Units[NumberToString[PositionBeingAnalyzed] - 49] + " Hundred";
                        NumberRank--;
                        break;
                    case 4:
                        ConvertedInput += Units[NumberToString[PositionBeingAnalyzed] - 49];
                        NumberRank--;
                        break;
                    case 5:
                        ConvertedInput += Tens[NumberToString[PositionBeingAnalyzed] - 49];
                        NumberRank--;
                        break;
                    case 6:
                        ConvertedInput += Units[NumberToString[PositionBeingAnalyzed] - 49] + " Hundred";
                        NumberRank--;
                        break;
                    case 7:
                        ConvertedInput += Units[NumberToString[PositionBeingAnalyzed] - 49] + " Million";
                        NumberRank--;
                        break;
                    default:
                        break;
                }
                

            }

            return ConvertedInput;
        }
    }
}
