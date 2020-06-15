using System;

namespace _813
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 813:");
            Task813();

        }
        private static void Task813()
        {
            // вводим строку
            Console.WriteLine("Введите текст: ");
            var input = Console.ReadLine().ToCharArray();
            if (char.IsLetter(input[0]) && char.IsLower(input[0]))
            {
                var data = IsNextNumber(input);
                var i = data.Item2;
                if (data.Item1)
                {
                    while (i < input.Length && char.IsDigit(input[i]))
                    {
                        input[i] = '*';
                        i++;
                    }
                }
            }
            Console.WriteLine(new string(input));
        }
        private static (bool, int) IsNextNumber(char[] input)
        {
            var i = 0;
            while (i != input.Length && char.IsLetter(input[i]) && char.IsLower(input[i]))
            {
                i++;
            }

            if (i == input.Length)
                return (false, -1);
            return char.IsDigit(input[i]) ? (true, i) : (false, -1);
        }

    }
}
