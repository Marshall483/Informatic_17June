using System;

namespace Ex810
{
    class Ex_810
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n:");
            int n = int.Parse(Console.ReadLine());
            if (n > 1000)
                throw new Exception("Введенное число n не соответсвует условиям (n<=1000)");

            int[] array_int = new int[3];

            if (n == 1000)
                Console.WriteLine("одна тысяча");

            array_int[0] = n % 1000;
            string result = "";
            for (int i = 0; i < 3; i++)
            {
                if (array_int[i] != 0)
                {
                    if (((array_int[i] - (array_int[i] % 100)) / 100) != 0)
                        switch (((array_int[i] - (array_int[i] % 100)) / 100))
                        {
                            case 1: result += "сто"; break;
                            case 2: result += "двести"; break;
                            case 3: result += "триста"; break;
                            case 4: result += "четыреста"; break;
                            case 5: result += "пятьсот"; break;
                            case 6: result += "шестьсот"; break;
                            case 7: result += "семьсот"; break;
                            case 8: result += "восемьсот"; break;
                            case 9: result += "девятьсот"; break;
                        }

                    if (((array_int[i] % 100) - ((array_int[i] % 100) % 10)) / 10 != 1)
                    {
                        switch (((array_int[i] % 100) - ((array_int[i] % 100) % 10)) / 10)
                        {
                            case 2: result += " двадцать"; break;
                            case 3: result += " тридцать"; break;
                            case 4: result += " сорок"; break;
                            case 5: result += " пятьдесят"; break;
                            case 6: result += " шестьдесят"; break;
                            case 7: result += " семьдесят"; break;
                            case 8: result += " восемьдесят"; break;
                            case 9: result += " девяносто"; break;
                        }
                    }

                    switch (array_int[i] % 10)
                    {
                        case 1: result += " один"; break;
                        case 2: result += " два"; break;
                        case 3: result += " три"; break;
                        case 4: result += " четыре"; break;
                        case 5: result += " пять"; break;
                        case 6: result += " шесть"; break;
                        case 7: result += " семь"; break;
                        case 8: result += " восемь"; break;
                        case 9: result += " девять"; break;
                    }
                }

                else switch (array_int[i] % 100)
                    {
                        case 10: result += " десять"; break;
                        case 11: result += " одиннадцать"; break;
                        case 12: result += " двенадцать"; break;
                        case 13: result += " тринадцать"; break;
                        case 14: result += " четырнадцать"; break;
                        case 15: result += " пятнадцать"; break;
                        case 16: result += " шестнадцать"; break;
                        case 17: result += " семнадцать"; break;
                        case 18: result += " восемннадцать"; break;
                        case 19: result += " девятнадцать"; break;
                    }
            }
            Console.WriteLine(result);
        }
    }
}
