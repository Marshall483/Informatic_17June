using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task684
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { 
                { 1, -2, 3, 4, 5 }, 
                { 2, 7, 8, 19, -10 }, 
                { 5, 67, 31, 12, 1 }, 
                { 1, 0, -15, 20, 45 }, 
                { -1, 2, 0, 55, 10 }
            };

            var n = matrix.GetLength(0); //Размерность квадратной матрицы

            int removingRow, removingCol;
            FindMax(matrix, out removingRow, out removingCol);

            matrix = CopyWithout(removingRow, removingCol, matrix);

            //Вывод получившейся матрицы
            Console.Write("\nРезультат : \n");
            for (var i = 0; i < n - 1; i++)
            {
                Console.Write("\n");
                for (var j = 0; j < n - 1; j++) 
                    Console.Write("{0}\t", matrix[i, j]);
            }
            Console.Write("\n\n");
        }

        //Находит индексы максимального элемента
        static int FindMax(int[,] m, out int row, out int col)
        {
            row = -1; col = -1;
            var max = int.MinValue;
            var n = m.GetLength(0);

            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (m[i, j] > max)
                    {
                        max = m[i, j];
                        row = i;
                        col = j;
                    }
                }
            }

            return max;
        }

        //Принимает на вход матрицу, строку и столбец, которые нужно удалить
        //Возвращает матрицу n-1 размерности
        static int[,] CopyWithout(int removingRow, int removingCol, int[,] m)
        {
            var result = new int[m.GetLength(0) - 1, m.GetLength(1) - 1];
            var n = m.GetLength(0);

            for (int i = 0, j = 0; i < n; i++)
            {
                if (i == removingRow)
                    continue;
                for (int k = 0, u = 0; k < n; k++)
                {
                    if (k == removingCol)
                        continue;
                    result[j, u] = m[i, k];
                    u++;
                }
                j++;
            }

            return result;
        }
    }
}
