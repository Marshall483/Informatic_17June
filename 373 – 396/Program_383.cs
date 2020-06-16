using System;
using System.Linq;

namespace ConsoleApp8
{
    class Program
    {
        static void Main()
        {
            var m = 18;
            var n = int.Parse(Console.ReadLine());
            var matrix = new double[m, n];
            var max = double.MinValue;
            var res = 0.0;
            var indexI = 0;
            var indexJ = 0;
            for (int i = 0; i < m; i++)
            {
                var input = Console.ReadLine().Split().Select(i => double.Parse(i)).ToArray();
                for (var j = 0; j < n; j++)
                {
                    var cur = input[j];
                    matrix[i, j] = cur;
                    var absCur = Math.Abs(cur);
                    if (absCur >= max)
                    {
                        max = absCur;
                        res = cur;
                        indexI = i;
                        indexJ = j;
                    }
                }
            }
            Console.WriteLine();

            Console.WriteLine("элемент {0} с индексами {1} {2}", res, indexI, indexJ);
        }
    }
}

