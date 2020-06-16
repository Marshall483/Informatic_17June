using System;

namespace _803
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int l = text.Length;
            for (int i = 0; i < l; i++)
            {
                if (!char.IsLetter(text[i]) && text[i] != ' ')
                {
                    Console.WriteLine("Да");
                    return;
                }
            }
            Console.WriteLine("Нет");
        }
    }
}
