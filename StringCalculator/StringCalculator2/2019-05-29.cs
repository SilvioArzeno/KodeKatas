using System;
using System.Collections.Generic;

namespace StringCalculator2
{
    class Program
    {

        static string Add(string input)
        {
            List<string> ErrorMessages = new List<string>();
            string[] separators = new string[2];
            if (input[0] == '/')
            {
                separators[0] = input[2].ToString();
                input = input.Substring(5);
            }
            else
            {
                separators[0] = ",";
                separators[1] = "\\n";
            }
            string[] numbers = input.Split(separators, StringSplitOptions.None);
            if (numbers[numbers.Length - 1] == "")
            {
                ErrorMessages.Add("Number expected but EOF found at position " + numbers.Length);
            }
            double num = 0;
            for (int i = 0; i < numbers.Length; i++) {

                if (numbers[i] != "" || numbers[i] != string.Empty)
                {

                    num += Convert.ToDouble(numbers[i]);

                }

                else if (numbers[i] == "" || numbers[i] == string.Empty)
                {
                    ErrorMessages.Add("Number expected but separator found at position " + i);
                    continue;
                }
                else if (Convert.ToInt32(numbers[i]) < 0)
                {
                    ErrorMessages.Add("Negative not allowed: " + numbers[i]);
                }
            }
            if(ErrorMessages.Count > 0)
            {
                foreach(string a in ErrorMessages)
                {
                    Console.WriteLine(a);

                }
                return null;
            }
                return num.ToString();
            
        }


        static void Main(string[] args)
        {
            for (int i = 0; i < 8; i++)
            {
                Console.Write("Type in some numbers to add: ");
                string input = Console.ReadLine();
                Console.WriteLine("Result: " + Add(input));
            }
            Console.ReadKey();
        }
    }
}
