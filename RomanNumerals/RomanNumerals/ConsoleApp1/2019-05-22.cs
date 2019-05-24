using System;

namespace ConsoleApp1
{
    class Program
    {

        static string ToRomanNumerals (int Decimal)
        {
            string RomanNumeral = string.Empty;
            
            
            while( Decimal - 1000 >= 0)
            {
                RomanNumeral += "M";
                Decimal -= 1000;
            }
            if (Decimal >= 900 && Decimal < 1000)
            {
                RomanNumeral += "CM";
                Decimal -= 900;
            }

            while (Decimal - 500 >= 0)
            {
                RomanNumeral += "D";
                Decimal -= 500;
            }
            if (Decimal >= 400 && Decimal < 500)
            {
                RomanNumeral += "CD";
                Decimal -= 400;
            }
            while (Decimal - 100 >= 0)
            {
                RomanNumeral += "C";
                Decimal -= 100;
            }
            if (Decimal >= 90 && Decimal < 100)
            {
                RomanNumeral += "XC";
                Decimal -= 90;
            }
            while (Decimal - 50 >= 0)
            {
                RomanNumeral += "L";
                Decimal -= 50;
            }
            if (Decimal >= 40 && Decimal < 50)
            {
                RomanNumeral += "XL";
                Decimal -= 40;
            }
            while (Decimal - 10 >= 0)
            {
                RomanNumeral += "X";
                Decimal -= 10;
            }
            if (Decimal >= 9 && Decimal < 10)
            {
                RomanNumeral += "IX";
                Decimal -= 9;
            }
            while (Decimal - 5 >= 0)
            {
                RomanNumeral += "V";
                Decimal -= 5;
            }
            if (Decimal >= 4 && Decimal < 5)
            {
                RomanNumeral += "IV";
                Decimal -= 4;
            }
            while (Decimal - 1 >= 0)
            {
                RomanNumeral += "I";
                Decimal -= 1;
            }
            return RomanNumeral;
        }

        static int ToDecimal(string RomanNumeral)
        {
            int Decimal = 0;

           for(int i = 0; i < RomanNumeral.Length; i++)
            {
                switch (RomanNumeral[i])
                {
                    case 'M':
                        if (i - 1 >= 0 && RomanNumeral[i - 1] == 'C')
                        {
                            Decimal += 900;
                        }
                        else
                        {
                            Decimal += 1000;
                        }
                        break;

                    case 'D':
                        if (i - 1 >= 0 && RomanNumeral[i - 1] == 'C')
                        {
                            Decimal += 400;
                        }
                        else
                        {
                            Decimal += 500;
                        }
                        break;

                    case 'C':
                        if (i - 1 >= 0 && RomanNumeral[i - 1] == 'X')
                        {
                            Decimal += 90;
                        }
                        else if (i + 1 < RomanNumeral.Length && (RomanNumeral [i + 1] == 'D' || RomanNumeral[i + 1] == 'M'))
                        {
                            break;
                        }
                        else
                        {
                            Decimal += 100;
                        }
                        break;

                    case 'L':
                        if (i - 1 >= 0 && RomanNumeral[i - 1] == 'X')
                        {
                            Decimal += 40;
                        }
                        else
                        {
                            Decimal += 50;
                        }
                        break;

                    case 'X':
                        if (i - 1 >= 0 && RomanNumeral[i - 1] == 'I')
                        {
                            Decimal += 9;
                        }
                        else if (i + 1 < RomanNumeral.Length && (RomanNumeral[i + 1] == 'L' || RomanNumeral[i + 1] == 'C'))
                        {
                            break;
                        }
                        else
                        {
                            Decimal += 10;
                        }
                        break;

                    case 'V':
                        if (i - 1 >= 0 && RomanNumeral[i - 1] == 'I')
                        {
                            Decimal += 4;
                        }
                        else
                        {
                            Decimal += 5;
                        }
                        break;

                    case 'I':

                        if (i + 1 < RomanNumeral.Length && (RomanNumeral[i + 1] == 'X' || RomanNumeral[i + 1] == 'V'))
                        {
                            break;
                        }
                        else
                        {
                            Decimal += 1;
                        }
                        break;
                    default:
                        break;
                }
            }
            return Decimal;
        }
        static void Main(string[] args)
        {
           for(int i = 0; i <= 5; i++)
            {
                Console.Write("Write a decimal number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(number + "------->" + ToRomanNumerals(number));
            }
            for (int i = 0; i <= 5; i++)
            {
                Console.Write("Write a Roman numeral: ");
                string number = Console.ReadLine();
                Console.WriteLine(number + "------->" + ToDecimal(number));
            }

            Console.ReadKey();
        }
    }
}
