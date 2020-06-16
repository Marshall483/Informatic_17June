using System;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;
using System.Threading;

namespace Temp
{
    class Program
    {

        static List<int> GetVector(int rank)
        {
            Random rnd = new Random();
            List<int> vector = new List<int>(rank);

            Thread.Sleep(100); //for random value

            for (int i = 0; i < rank; i++)
                vector.Add(rnd.Next(0, 20));

            return vector;
        }

        static void PrintMatrix(List<List<int>> matrix)
        {
            foreach (List<int> vector in matrix)
            {
                Console.WriteLine();
                foreach (int el in vector)
                    Console.Write(el + " ");
            }
            Console.WriteLine();
        }

        static void ModifyMatrix()//682
        {
            int n = int.Parse(Console.ReadLine());

            int r = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            if (r > n || l > n || r < 1 || l < 1 || r == l)
                throw new Exception("Incorrect data");



            List<List<int>> matrix = new List<List<int>>();

            for (int str = 0; str < n; str++)
                matrix.Add(GetVector(3));

            PrintMatrix(matrix);

            if (l + 1 == r) return;

            List<int> temp = matrix[r];
            matrix.Remove(temp);

            List<List<int>> modifyMatrix = new List<List<int>>();

            for (int i = 0; i < r - 1; i++)
                modifyMatrix.Add(matrix[i]);

            modifyMatrix.Add(temp);

            for (int i = r - 1; i < n - 1; i++)
                modifyMatrix.Add(matrix[i]);

            PrintMatrix(modifyMatrix);

        }

        static void Main() 
        {

            ModifyMatrix();


            Console.ReadKey();
        }


    }
}
