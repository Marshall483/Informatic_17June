using System;

namespace _118
{
    class Program
    {
        static void Main(string[] args)
        {
            //A
            var sum = 0.0;
            for(int i = 1; i <= 10000; i++)
            {
                if (i % 2 != 0)
                {
                    sum += ((double)1 / (double)i);
                }
                else
                {
                    sum -= ((double)1 / (double)i);
                }
            }
            Console.WriteLine("a) " + sum);
            //Б
            var firstsum = 0.0;
            var secondsum = 0.0;
            for(int i = 1; i <= 9999; i += 2)
            {
                
                firstsum += ((double)1 / (double)i);
            }

            for(int i = 2; i <= 10000; i += 2)
            {
                
                secondsum += ((double)1 / (double)i);
            }
            sum = (double)firstsum - (double)secondsum;
            Console.WriteLine("б) " + sum);
            //В
            sum = 0;
            for(int i = 10000; i >= 1; i--)
            {
                if (i % 2 != 0)
                {
                    sum += ((double)1 / (double)i);
                }
                else
                {
                    sum -= ((double)1 / (double)i);
                }
            }
            Console.WriteLine("в) " + sum, 5);
            //Г
            firstsum = 0.0;
            secondsum = 0.0;
            for (int i = 9999; i >= 1; i -= 2)
            {

                firstsum += ((double)1 / (double)i);
            }

            for (int i = 10000; i >=2; i -= 2)
            {

                secondsum += ((double)1 / (double)i);
            }
            sum = (double)firstsum - (double)secondsum;
            Console.WriteLine("г) " + sum);
            /*
             * Ответ на последний вопрос
             * https://habr.com/ru/post/112953/
             */
        }
    }
}
