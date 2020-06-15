using System;

namespace _812
{
    class Program
    {
        static void Main(string[] args)
        {
            //Б
            Task812B();
            //Г
            Task812G()

        }
        public static void Task812G()
        {
            Console.WriteLine("Введите строку");
            var input = Console.ReadLine();
            var answer = 0;
            for (var i = 0; i < input.Length; i++)
            {
                i = GetNextLetterGroup(i, input);
                if (i >= input.Length)
                    break;
                var start = input[i];// первый символ
                while (i != input.Length && char.IsLetter(input[i]))
                    i++;
                if (start == input[i - 1])
                    answer++;
            }
            Console.WriteLine(answer);

        }
        private static int GetNextLetterGroup(int index, string input)
        {
            while (index != input.Length && !char.IsLetter(input[index]))
                index++;
            return index;
        }

        public static void Task812B()
        {
            // вводим строку
            var input = Console.ReadLine();
            var isNew = true;
            var letter = 0;
            var signs = 0;
            for (var i = 0; i < input.Length; i++)
            {
                if (isNew)
                {
                    if (char.IsDigit(input[i])) continue;
                    if (char.IsLetter(input[i]))
                    {
                        letter++;
                    }
                    else
                    {
                        signs++;
                    }
                }
                //Проверяем, новая ли группа идет вслед за текущим символом
                if (i != input.Length - 1 &&
                    (
                        char.IsLetter(input[i]) == char.IsLetter(input[i + 1]) ||
                        char.IsDigit(input[i]) == char.IsDigit(input[i + 1]) ||
                        ((input[i] == '*' || input[i] == '-' || input[i] == '+') && (input[i + 1] == '*' || input[i + 1] == '-' || input[i + 1] == '+'))
                    )
                    )
                {
                    isNew = false;
                }
                else
                {
                    isNew = true;
                }
            }

            Console.WriteLine(letter > signs
                ? "В данном тексте больше групп букв, чем групп знаков"
                : "В данном тексте больше групп знаков, чем групп букв");

        }

    }
}
