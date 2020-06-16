using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _807
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> mas = new HashSet<string>(); //Автоматически убирает все дубликаты
            Console.WriteLine("Введите n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите m");
            int m = int.Parse(Console.ReadLine());
            char[,] charmas = new char[n, m];
            Console.WriteLine("Введите элементы матрицы");
            for (int i = 0; i < n; i++) //заполняем матрицу 
                for (int j = 0; j < m; j++)
                    charmas[i,j] = Convert.ToChar(Console.ReadLine());
            for (int i = 0; i < n; i++) 
            {
                StringBuilder ans = new StringBuilder();
                for (int j = 0; j < m; j++) ans.Append(charmas[i, j].ToString());
                mas.Add(ans.ToString());
            }
            Console.WriteLine("Ответ:");

            foreach (var a in mas)
                Console.WriteLine(a);

        }
    }
}
