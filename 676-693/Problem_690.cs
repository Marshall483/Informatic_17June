using System;

namespace Problem_690
{
    class Program
    {

        public static void Solution()
        {
            double[,] array = new double[7, 7];
            string values = "";

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    array[i, j] = new Random().Next(0, 50);
                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }

            // У нас будет 4 действия: 2 из них будут проходить по всем значениям по строкам (слева направо и справа налево), остальные
            // 2 будут идти по колонкам (сверху вниз и снизу вверх). Значения *_min соответсвуют "крайним минимальным" строчкам/столбцам
            // они будут увеличиваться. Значения *_max наоборот, "крайние максимальные", они будут уменьшаться. Значения р_min и p_max 
            // будут равны, то это значит, что пора выходить из цикла

            int strings_min = 0;
            int columns_min = 0;
            int columns_max = 6;
            int strings_max = 6;

            while (true)
            {
                //Добавляем последний элемент и выходим из цикла
                if (strings_min == strings_max)
                {
                    values += array[strings_min, columns_max];
                    break;
                }

                //Чтение строки слева направо
                for (int j  = columns_min; j <= columns_max; j++)
                    values += array[strings_min, j] + " ";

                strings_min++;

                //Чтение колонны сверху вниз
                for (int i = strings_min; i <= strings_max; i++)
                    values += array[i, columns_max ] + " ";

                columns_max--;

                //Чтение строки справа налево
                for (int j = columns_max; j >= columns_min; j--)
                    values += array[strings_max, j] + " ";

                strings_max--;

                //Чтение колонны снизу вверх
                for (int i = strings_max; i >= strings_min; i--)
                    values += array[i, columns_min] + " ";

                columns_min++;

            }

            Console.WriteLine("\n" + values);
  
        }

        static void Main(string[] args)
        {
            Solution();
        }
    }
}
