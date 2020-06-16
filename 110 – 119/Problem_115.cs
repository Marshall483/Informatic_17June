using System;

namespace Problem_115
{
    class Program
    {

        public static void Solution()
        {
            Console.WriteLine("Введите n");
            var n = Convert.ToInt32(Console.ReadLine());

            decimal final = 0M;


                    // a:
                    for (int k = 1; k <= n; k++)
                        final += (decimal)1 / k;



                    // б:
                    for (int k = 1; k <= n; k++)
                        final += (decimal)(1 / Math.Pow(k, 5));

                    //в: 
                    for (int k = 1; k <= n; k++)
                        final += (decimal)(1 / Math.Pow(2 * k + 1, 2));



                    // г:
                    for (int k = 1; k <= n; k++)
                        final += (decimal)(Math.Pow(-1, k) / ((2 * k + 1) * k));


                    // д:
                    for (int k = 1; k <= n; k++)
                        final += (decimal)(Math.Pow(-1, k + 1) / (k * (k + 1)));


                    // е, ж: (присваиваем final значение перед циклом, чтобы не мучиться с if'ами из-за факториала, все равно он
                    // будет равен по умолчанию -2 и 2)
                    // е:
                    final += -2;
                    for (int k = 2; k <= n; k++)
                        final += (decimal)(Math.Pow(-1, k) * (k + 1) / (k * (k - 1)));


                    // ж:
                    final += 2;
                    for (decimal k = 2, divider = (decimal)(1 / 2M); k <= n; k++)
                    {
                        divider += (1 / (k + 1));

                        final += ((k * (k - 1) / divider));
                    }


            Console.WriteLine(final.ToString("N9"));
        }
        static void Main(string[] args)
        {
            Solution();
        }
    }
}
