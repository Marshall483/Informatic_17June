using System;
using System.Text;

namespace _805
{
    class Program
    {
        static void Main(string[] args)
        {
            Task805();
        }
        private static void Task805()
        {
            Console.WriteLine("Введите строку: ");
            var str = Console.ReadLine();
            var i = 0;
            StringBuilder st = new StringBuilder();
            st.Append(str);

            var flag = true;
            while (str[i] <= 'z' && str[i] >= 'a' || flag)
            {
                if (str[i] >= 'A' && str[i] <= 'Z' && flag)
                {
                    flag &= true;
                }
                if (str[i] <= 'z' && str[i] >= 'a')
                {
                    flag &= false;
                }
                i++;
            }

            while (i < str.Length)
            {
                st[i] = '.';
                i++;
            }
            Console.WriteLine(st);
        }
    }
}
