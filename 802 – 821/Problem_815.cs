using System;

namespace Problem_815
{
    class Program
    {
        public static void Solution()
        {

            char[,] board = new char[8, 8];

            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    board[i, j] = '0';

            Console.WriteLine("Введите n");
            byte n = (byte) (Convert.ToByte(Console.ReadLine()) - 1);
            Console.WriteLine("Введите m");
            byte m = (byte)(Convert.ToByte(Console.ReadLine()) - 1);

            //Тут две задачи, чтобы продемонстрировать одну - закомментируй другую
            #region Для ферзя

            ////Наискось c верхней правой точки в нижнюю левую
            //{
            //    if (n - 7 + m  >= 0)
            //        for (int i = m + n - 7, j = 7; i < 8 & j >= 0; i++, j--)
            //            board[i, j] = '*';

            //    else
            //        for (int i = 0, j = m + n ; i < 8 & j >= 0; i++, j--)
            //            board[i, j] = '*';
            //}

            ////Наискось с нижней правой точки в левую верхнюю
            //{

            //    if (n - m >= 0)
            //        for (int i = 7, j = 7 + m - n; i >= 0 & j >= 0; i--, j--)
            //            board[i, j] = '*';

            //    else
            //        for (int i = 7 - m + n, j = 7; i >= 0 & j >= 0; i--, j--)
            //            board[i, j] = '*';

            //}

            ////Идем сверху вниз
            //for (int i = 0; i < 8; i++)
            //    board[i, m] = '*';

            ////Идем слева направо
            //for (int j = 0; j < 8; j++)
            //    board[n, j] = '*';

            //board[n, m] = 'ф';
            #endregion

            #region Для коня
            board[n, m] = 'к';

            if (n - 2 >= 0 & m - 1 >= 0)
                board[n - 2, m - 1] = '*';

            if (n - 1 >= 0 & m - 2 >= 0)
                board[n - 1, m - 2] = '*';

            if (n - 2 >= 0 & m + 1 < 8)
                board[n - 2, m + 1] = '*';

            if (n - 1 >= 0 & m + 2 < 8)
                board[n - 1, m + 2] = '*';

            if (n + 1 < 8 & m - 2 >= 0)
                board[n + 1, m - 2] = '*';

            if (n + 2 < 8 & m - 1 >= 0)
                board[n + 2, m - 1] = '*';

            if (n + 1 < 8 & m + 2 < 8)
                board[n + 1, m + 2] = '*';

            if (n + 2 < 8 & m + 1 < 8)
                board[n + 2, m + 1] = '*';
            #endregion


            //тУпА ВыВоД :=D
            for (int i = 0; i < 8; i++) {
                for (int j = 0; j < 8; j++)
                    Console.Write(board[i, j] + "  ");

                Console.WriteLine();
            }

        }

        static void Main(string[] args)
        {

            Solution();
        }
    }
}
