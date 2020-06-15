using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _805
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder s = new StringBuilder(Console.ReadLine());
            Regex r = new Regex(@"[a-z]"); 
            for(int i = 0; i < s.Length; i++)
            {
                if(r.IsMatch(s[i].ToString()))
                {
                    int j = i+1;
                    try
                    {
                        while (r.IsMatch(s[j].ToString()))
                        {
                            j++;
                        }
                        int len = s.Length;
                        s.Remove(j, s.Length - j);
                        for (int k = j; k < len; k++)
                        {
                            s.Append('.');
                        }
                    }
                    catch
                    {
                        
                    }
                    break;
                }
            }
            Console.WriteLine(s);
        }
    }
}
