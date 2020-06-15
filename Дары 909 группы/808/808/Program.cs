using System;
using System.Collections.Generic;

namespace _808
{
    class Program
    {
        static void Main(string[] args)
        {//A
            Task808A();



           
            // G
            Task808G();

        }
        public static void Task808A()
        {
            var text = Console.ReadLine();
            var words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var dict = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!dict.ContainsKey(word))
                {
                    dict.Add(word, 1);
                }
                else
                {
                    dict[word]++;
                }
            }

            foreach (var key in dict.Keys)
            {
                Console.WriteLine("Слово \"{0}\" встречается {1} раз(а)", key, dict[key]);
            }

        }
        static void Task808G()
        {
            var text = "I am playing football, he is drinking water";
            var words = text.Split();
            for (int i = 0; i < words.Length; i++)
            {
                var current = words[i];
                var len = current.Length;
                if (len >= 3 && current.Substring(len - 3) == "ing")
                //current[len - 1] == 'g' &&
                //current[len - 2] == 'n' &&
                //current[len - 3] == 'i')
                {
                    words[i] = current.Substring(0, len - 3) + "ed";
                }
                Console.Write(words[i] + " ");
            }
        }
    }
}
