using System;

namespace StringCalculator
{
    class Program
    {
        static string Add(params string[] numbers)
        {
            double num = 0;

            foreach(string a in numbers)
            {
                try
                {
                    if(a[0] == '-')
                    {
                        return "No negative numbers allowed";
                    }
                    if (a == " " || a == string.Empty)
                    {
                        continue;
                    }
                    num += Convert.ToDouble(a);
                }
                catch (Exception)
                {
                    return "Incorrect format!";
                }
            }
            return num.ToString();
        }

        static void Main(string[] args)
        {
            Console.Write("Write down some numbers to add separated by commas: ");
            string input = Console.ReadLine();
            
            string[] separators = { ",", "\\n" };
            if (input[0] == '/')
            {
                separators[0] = input[2].ToString();
                input = input.Substring(5);
            }
            if (input[input.Length-1].ToString() == separators[0] || input[input.Length-1] == 'n')
            {
                Console.WriteLine("Number expected but EOF found");
                Console.ReadKey();
                return;
            }
            string[] numbers = input.Split(separators,StringSplitOptions.None);
            Console.WriteLine("The sum is: " + Add(numbers));
            Console.ReadKey();
        }
    }
}
