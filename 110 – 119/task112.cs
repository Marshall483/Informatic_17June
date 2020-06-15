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

            //112(вычислить (n(n-1)...(n-k+1))/k! при (n>=k>=0))
            n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int const_n=n;
            int fac_k = 1;
            for(int i = 1; i<=k; i++)
            {
                if(i<k)
                    n *= (const_n - i);
                else if (i == k)
                    n *= (const_n - k + 1);
                fac_k *= i;
            }
            Console.WriteLine(n / fac_k);
            //335a()
            n = int.Parse(Console.ReadLine());
            int sum = 0;
            int temp_k=1;
            k = 1;
            for(int i =1; i<=n; i++)
            {
                if(i<k)
                    temp_k *= k + i;
                if (i == k)
                    temp_k *= k * k;
                sum += temp_k;
                k++;
                temp_k = k;
            }
            Console.WriteLine(sum);
            //375 ()
            Random rand = new Random();
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, m];
            int max = 0;
            for(int i=0; i<n;i++)
                for(int j = 0; j<m; j++)
                {
                    mat[i, j] = rand.Next(-40, 40);
                    if (Math.Abs(mat[i, j]) > max)
                        max = Math.Abs(mat[i, j]);
                }
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    mat[i, j] =mat[i,j]/max;
                }

            //678(транспонирование матрицы)
            n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int tmp;
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    tmp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = tmp;
                }
            }
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    matrix[i, j] ^= matrix[j, i];
                    matrix[j, i] ^= matrix[i, j];
                    matrix[i, j] ^= matrix[j, i];
                }
            }
            //804b(если в тексте нет символа "+", то оставить без изменения, иначе каждую цифру перед "+" заменить на "-")
            var text = Console.ReadLine();
            var index = text.IndexOf('+');
            if (index >= 0)
            {
                var result = new StringBuilder();
                result.Append(text);
                for (int i = 0; i < index; i++)
                {
                    if (char.IsDigit(result[i]))
                        result[i] = '-';
                }
                text = result.ToString();
            }
            Console.WriteLine(text);
        }
    }
}
