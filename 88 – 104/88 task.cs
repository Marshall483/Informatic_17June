
using System;
using System.Text;

namespace Informatic
{
    class Program
    {
        static void Main() //88
        {
            Console.WriteLine("Введите число...");
            int n = int.Parse(Console.ReadLine());

            //Содержит ли 3
            Console.WriteLine(n.ToString().Contains("3") ? "Содержит 3"  : "Не содержит 3");

            //Поменять порядок цифр на обратный
            StringBuilder value = new StringBuilder(n.ToString());
            for (int i = value.Length - 1; i >= 0; i--)
                Console.Write(value[i]);
            Console.WriteLine();

            //Поменять 1 и последнюю цифру местами
            char temp = value[0];
            value[0] = value[value.Length - 1];
            value[value.Length - 1] = temp;
            Console.WriteLine(value);

            //Приписать 1 в начало и конец
            StringBuilder newValue = new StringBuilder(value.Length + 2);
            newValue.Append(1);
            newValue.Append(value);
            newValue.Append(1);
            Console.WriteLine(newValue);

            Console.ReadKey();
        }
    }
}
