using System;

namespace Problem_390
{
    class Program
    {
        public static void Solution()
        {
            Console.WriteLine("Введите n");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите m");
            int m = Convert.ToInt32(Console.ReadLine());

            double[,] array = new double[n, m];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"Введите значение элемента {i}-ой строки {j}-го столбца");
                    array[i, j] = double.Parse(Console.ReadLine());
                }

            Console.WriteLine("\n" + "Введите значение k");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

                    // а:
                    for (double e = 1, max = array[k, 0]; e < m; e++)
                    {
                        if (array[k, (int)e] > max)
                            max = array[k, (int)e];

                        if (e + 1 == m)
                            Console.WriteLine(max);
                    }

                    // б:

                    for (double e = 1, min = array[k, 0], max = min; e < m; e++)
                    {
                        if (array[k, (int)e] < min)
                            min = array[k, (int)e];

                        else
                            max = array[k, (int)e];

                        if (e + 1 == m)
                            Console.WriteLine(max + min);
                    }


                    // в:
 
                    for (int e = 0, counter = 0; e < m; e++)
                    {
                        if (array[k, e] < 0)
                            counter++;

                        if (e + 1 == m)
                            Console.WriteLine(counter);
                    }

                    // г:

                    for (double e = 0, composition = 0; e < m; e++)
                    {
                        if (Math.Abs(array[k, (int)e]) >= 1 & Math.Abs(array[k, (int)e]) <= 1.5)
                        {
                            if (composition == 0)
                                composition = 1;

                            composition *= Math.Pow(array[k, (int)e], 2);
                        }

                        if (e + 1 == m)
                            Console.WriteLine(composition);
                    }

        }

        static void Main(string[] args)
        {
            Solution();

        }
    }
}
