using System;

namespace RomanNumerals
{
    class Program
    {

        static string ToRoman(int number)
        {

            string RomanNumeral = string.Empty;

           if(number >= 1000 - 100 && number < 1000)
            {
                RomanNumeral += "CM";
                number -= 900;
            }
            
            while (number - 1000 >= 0)
            {
                RomanNumeral += "M";
                number -= 1000;
            }

            if (number >= 500 - 100 && number < 500)
            {
                RomanNumeral += "CD";
                number -= 400;
            }
            while (number - 500 >= 0)
            {
                RomanNumeral += "D";
                number -= 500;
            }

            if (number >= 100 - 10 && number < 100)
            {
                RomanNumeral += "XC";
                number -= 90;
            }
            while (number - 100 >= 0)
            {
                RomanNumeral += "C";
                number -= 100;
            }

            if (number >= 50 - 10 && number < 50)
            {
                RomanNumeral += "XL";
                number -= 40;
            }

            while (number - 50 >= 0)
            {
                RomanNumeral += "L";
                number -= 50;
            }

            if (number >= 10 - 1 && number < 10)
            {
                RomanNumeral += "IX";
                number -= 9;
            }
            while (number - 10 >= 0)
            {
                RomanNumeral += "X";
                number -= 10;
            }

            if (number >= 5 - 1 && number < 5)
            {
                RomanNumeral += "IV";
                number -= 4;
            }
            while (number - 5 >= 0)
            {
                RomanNumeral += "V";
                number -= 5;
            }

            while (number - 1 >= 0)
            {
                RomanNumeral += "I";
                number -= 1;
            }
            return RomanNumeral;
        }

        static int ToDecimal(string RomanNumeral)
        {
            int Number = 0;
            foreach(char a in RomanNumeral)
            {
                switch (a)
                {
                    case 'I':
                        Number += 1;
                        break;

                    case 'V':
                        Number += 5;
                        break;

                    case 'X':
                        Number += 10;
                        break;

                    case 'L':
                        Number += 50;
                        break;

                    case 'C':
                        Number += 100;
                        break;

                    case 'D':
                        Number += 500;
                        break;

                    case 'M':
                        Number += 1000;
                        break;

                    default:
                        break;
                }
            }

            return Number;
        }

        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.Write("Write down a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(number + " ---->  " + ToRoman(number));
               
            }

            for (int i = 0; i <= 10; i++)
            {
                Console.Write("Write down a RomanNumber: ");
                string number = Console.ReadLine();
                Console.WriteLine(number + " ---->  " + ToDecimal(number));

            }
            Console.ReadKey();
        }

        
    }
}
