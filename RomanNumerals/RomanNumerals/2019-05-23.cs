using System;

namespace RomanNumerals
{
    class Program
    {
        static string ToRoman(int number)
        {
            string RomanNumeral = string.Empty;

            
            while( number - 1000 >= 0)
            {
                RomanNumeral += "M";
                number -= 1000;
            }
            if (number >= 900 && number - 100 < 900)
            {
                RomanNumeral += "CM";
                number -= 900;
            }
           
            while (number - 500 >= 0)
            {
                RomanNumeral += "D";
                number -= 500;
            }
            if (number >= 400 && number - 100 < 400)
            {
                RomanNumeral += "CD";
                number -= 400;
            }
            
            while (number - 100 >= 0)
            {
                RomanNumeral += "C";
                number -= 100;
            }
            if (number >= 90 && number - 10 < 90)
            {
                RomanNumeral += "XC";
                number -= 90;
            }
           
            while (number - 50 >= 0)
            {
                RomanNumeral += "L";
                number -= 50;
            }
            if (number >= 40 && number - 10 < 40)
            {
                RomanNumeral += "XL";
                number -= 40;
            }
           
            while (number - 10 >= 0)
            {
                RomanNumeral += "X";
                number -= 10;
            }
            if (number >= 9 && number - 1 < 9)
            {
                RomanNumeral += "IX";
                number -= 9;
            }
            
            while (number - 5 >= 0)
            {
                RomanNumeral += "V";
                number -= 5;
            }
            if (number >= 4 && number - 1 < 4)
            {
                RomanNumeral += "IV";
                number -= 4;
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
            int number = 0;

            for(int i = 0; i < RomanNumeral.Length; i++)
            {
                switch (RomanNumeral[i])
                {
                    case 'M':
                        if(i -1 >= 0 && RomanNumeral[i-1] == 'C')
                        {
                            number += 900;
                        }
                        else
                        {
                            number += 1000;
                        }
                        break;

                    case 'D':
                        if(i - 1 >= 0 && RomanNumeral[i-1] == 'C')
                        {
                            number += 400;
                        }
                        else
                        {
                            number += 500;
                        }
                        break;
                    case 'C':
                        if (i - 1 >= 0 && RomanNumeral[i - 1] == 'X')
                        {
                            number += 90;
                        }
                        else if ( i + 1 < RomanNumeral.Length && (RomanNumeral[i+1] == 'M' || RomanNumeral[i + 1] == 'D'))
                        {
                            break;
                        }
                        else
                        {
                            number += 100;
                        }
                        break;

                    case 'L':
                        if (i - 1 >= 0 && RomanNumeral[i - 1] == 'X')
                        {
                            number += 40;
                        }
                        else
                        {
                            number += 50;
                        }
                        break;

                    case 'X':
                        if (i - 1 >= 0 && RomanNumeral[i - 1] == 'I')
                        {
                            number += 9;
                        }
                        else if (i + 1 < RomanNumeral.Length && (RomanNumeral[i + 1] == 'L' || RomanNumeral[i + 1] == 'C'))
                        {
                            break;
                        }
                        else
                        {
                            number += 10;
                        }
                        break;

                    case 'V':
                        if (i - 1 >= 0 && RomanNumeral[i - 1] == 'I')
                        {
                            number += 4;
                        }
                        else
                        {
                            number += 5;
                        }
                        break;

                    case 'I':

                        if (i + 1 < RomanNumeral.Length && (RomanNumeral[i + 1] == 'V' || RomanNumeral[i + 1] == 'X'))
                        {
                            break;
                        }
                        else
                        {
                            number += 1;
                        }
                        break;
                    default:
                        break;
                }
            }

            return number;
        }

        static void Main(string[] args)
        {
           for(int i = 0; i <= 5; i++)
            {
                Console.Write("Write down your number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(number + " ---------> " + ToRoman(number));
            }
            for (int i = 0; i <= 5; i++)
            {
                Console.Write("Write down your Roman Numeral: ");
                string number = Console.ReadLine();
                Console.WriteLine(number + " ---------> " + ToDecimal(number));
            }

            Console.ReadKey();
        }
    }
}
