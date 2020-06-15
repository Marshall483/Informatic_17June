using System;
using System.Collections.Generic;
using System.Text;
namespace exam
{
    class Program
    {
        static int GCD(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            return b;
        }
        static void PQSearch(ref int a, ref int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Обнаружено деление на ноль!");
                return;
            }
            while (GCD(a,b)!=1)
            {
                if(a % b==0)
                {
                    a = a / b;
                    b = b / b;
                }
                else if (b % a == 0)
                {
                    b = b / a;
                    a = a / a;
                }
                if (a % 8 == 0 && b % 8 == 0)
                {
                    a = a / 8;
                    b = b / 8;
                }
                else if (a % 4 == 0 && b % 4 == 0)
                {
                    a = a / 4;
                    b = b / 4;
                }   
                else if (a % 2 == 0 && b % 2 == 0)
                {
                    a = a / 2;
                    b = b / 2;
                }
                if (a % 9 == 0 && b % 9 == 0)
                {
                    a = a / 9;
                    b = b / 9;
                }
                else if(a%3==0 && b%3 == 0)
                {
                    a = a / 3;
                    b = b / 3;
                }
                if (a % 5 == 0 && b % 5 == 0)
                {
                    a = a / 5;
                    b = b / 5;
                }
                if (a % 7 == 0 && b % 7 == 0)
                {
                    a = a / 7;
                    b = b / 7;
                }
            }
        }
        static void Main(string[] args)
        {
            //90(поиск p и q таких, что их НОД равен 1 и p/q==m/n)
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            PQSearch(ref m, ref n);
            Console.WriteLine($"p={m},q={n}");
        }
