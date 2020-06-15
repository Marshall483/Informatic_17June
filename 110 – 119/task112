using System;
using System.Collections.Generic;
using System.Text;
namespace exam
{
    class Program
    {
       
        static void Main(string[] args)
        {
            
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
         }
   }
}
