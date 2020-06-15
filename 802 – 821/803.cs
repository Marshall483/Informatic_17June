using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _803
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[^A-Za-zА-Яа-яё\s]"; //ищет символы не свопадающие с англ+рус алфавитом и пробелом "\s"
            Regex regex = new Regex(pattern);
            Console.WriteLine("Введите строку");
            string s = Console.ReadLine();
            if (regex.IsMatch(s)) Console.WriteLine("В тексте есть символы отличные от букв и пробела"); //если нашли 
            //хоть одно вхождение, то в тексте есть иные знаки 
            else Console.WriteLine("В тексте нет символов отличных от букв и пробела"); 



        }
        
    }
}
