using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task381
{
    class Program
    {
        static void Main(string[] args)
        {
            const int size = 10;

            var matrix = new int[size, size];
            matrix = MatrixFromFile(@"C:\Users\dirtyjesuss\source\repos\Task119\119 task input.txt"); //Введи сюда свой путь к файлу

            var max = int.MinValue;

            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size; j++)
                {
                    max = matrix[i, j] > max ? matrix[i, j] : max;
                }
            }

            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size; j++)
                {
                    if (matrix[i, j] == max)
                        matrix[i, j] = 0;
                }
            }

            Console.Write("\nРезультат : \n");
            for (var i = 0; i < size; i++)
            {
                Console.Write("\n");
                for (var j = 0; j < size; j++)
                    Console.Write("{0}\t", matrix[i, j]);
            }
            Console.Write("\n\n");
        }

        //Возвращает матрицу, считанную из файла
        static int[,] MatrixFromFile(string path)
        {
            var input = File.ReadAllText(path);

            var i = 0;
            var j = 0;
            var result = new int[10, 10];
            foreach (var row in input.Split('\n'))
            {
                j = 0;
                foreach (var col in row.Trim().Split(' '))
                {
                    result[i, j] = int.Parse(col.Trim());
                    j++;
                }
                i++;
            }
            return result;
        }
    }
}

