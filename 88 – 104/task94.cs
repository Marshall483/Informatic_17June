using System;

namespace Task94
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] u = new double[3];
            u[0] = 0;
            u[1] = 0;
            double[] v = new double[3];
            int count = 1;
            v[0] = 1;
            v[1] = 1;
            Console.Write("Введите N : ");
            int n = int.Parse(Console.ReadLine());
            for(int i =3; i <= n; i++) 
            {              
                u[2] = (u[1] - u[0]*v[1]-v[0])/(1+u[1]* u[1]+v[1]* v [1]);
                
                v[2] = (u[1] - v[1]) / (Math.Abs(u[0]+ v[1])+2);
               
                u[0] = u[1];
                u[1] = u[2];
                v[0] = v[1];
                v[1] = v[2];
                count++;
            }
            Console.WriteLine("Vn = "+v[2]);
            
        }
    }
}
