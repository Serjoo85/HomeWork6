using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace ToolsLib
{
    public static class Tools
    {
        /// <summary>
        /// Проверка пользовательского ввода на число.
        /// </summary>
        /// <param name="msg">Сообщение для пользователя перед вводом данных</param>
        /// <returns>Число которое ввел пользователь</returns>
        public static int CheckNumber(string msg)
        {
            string userText = "";
            int x = 0;
            do
            {
                Console.WriteLine(msg);
                userText = Console.ReadLine();
                Console.Clear();
                if (int.TryParse(userText, out x))
                {                    
                    return x;
                }
                else
                {                    
                    Console.WriteLine($"Ошибка! Введенные данные должны быть целым числом.");
                }
            }
            while (true);
        }

        /// <summary>
        /// Проверка пользовательского ввода на число.
        /// </summary>
        /// <param name="msg">Сообщение для пользователя перед вводом данных</param>
        /// <param name="except">Исключение для ввода</param>
        /// <returns>Число которое ввел пользователь</returns>
        public static int CheckNumber(string msg, int except)
        {
            string userText = "";
            int x = 0;
            do
            {
                Console.WriteLine(msg);
                userText = Console.ReadLine();
                Console.Clear();
                if (int.TryParse(userText, out x))
                {
                    if(x != except)
                    {
                        return x;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка! Недопустимое значение числа.");
                    }                    
                }
                else
                {
                    Console.WriteLine($"Ошибка! Введенные данные должны быть целым числом.");
                }
            }
            while (true);
        }

        /// <summary>
        /// Проверка пользовательского ввода на число.
        /// </summary>
        /// <param name="msg">Сообщение для пользователя перед вводом данных</param>
        /// <param name="min">Минимальное значение</param>
        /// <param name="max">Максимальное значение</param>
        /// <returns>Число которое ввел пользователь</returns>
        public static int CheckNumber(string msg, int min, int max)
        {
            string userText = "";
            int x = 0;
            do
            {
                Console.WriteLine(msg);
                userText = Console.ReadLine();
                Console.Clear();
                if (int.TryParse(userText, out x))
                {
                    if (x < min | x > max)
                    {                        
                        Console.WriteLine($"Ошибка! Введенные данные должны быть целым числом от {min} до {max}");                        
                    }
                    else
                    {                        
                        return x;
                    }
                }
            }
            while (true);
        }
        
        /// <summary>
        /// Вывод двумерного массива вконосль.
        /// </summary>
        /// <typeparam name="T">Обобщенное значение</typeparam>
        /// <param name="Arr">Двумерный массив для вывода</param>
        /// <returns></returns>
        public static string ArrayPrint<T>(T[,] Arr)
        {            
            string arrRepres = "        ";
            for (int k = 0; k < Arr.GetLength(1); k++)
            {
                arrRepres += $"{k:d2}   ";
            }
            arrRepres += "\n\n";
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                arrRepres += $"Ряд {i:d2}  ";
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    arrRepres += String.Format("{0:d2}",Arr[i, j]) + "   ";
                }
                arrRepres += "\n\n";
            }
            return arrRepres;
        }

        /// <summary>
        /// Вывод двумерного массива вконосль.
        /// </summary>
        /// <typeparam name="T">Обобщенное значение</typeparam>
        /// <param name="Arr">Двумерный массив для вывода</param>
        /// <param name="indexList">Список индексов для вывода</param>
        /// <returns></returns>
        public static void ArrayPrintColor<T>(T[,] Arr, List<int[]> indexList)
        {
            void ColorMark(int X, int Y)
            {
                foreach (int[] value in indexList) 
                {
                    if (value[0] == X & value[1] == Y) Console.ForegroundColor = ConsoleColor.Red; 
                }
            }
            void Print1(string txt) { Console.Write(txt); }

            Print1("        ");
            for (int k = 0; k < Arr.GetLength(1); k++) { Print1($"{k:d2}" + "   "); }
            Print1("\n\n");
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                Print1($"Ряд {i:d2}  ");
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    ColorMark(i, j);
                    Print1($"{Arr[i, j]:d2}" + "   ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Print1("\n\n");
            }            
        }

        /// <summary>
        /// Вывод двумерного массива вконосль.
        /// </summary>
        /// <typeparam name="T">Обобщенное значение</typeparam>
        /// <param name="Arr">Двумерный массив для вывода</param>
        /// <param name="Red">Красная подсветка</param>
        /// <param name="Blue">Синяя подсветка</param>
        /// <returns></returns>
        public static void ArrayPrintColor<T>(T[,] Arr, List<int[]> Red, List<int[]> Blue)
        {
            void ColorMark(int X, int Y)
            {
                foreach (int[] value in Red)
                {
                    if (value[0] == X & value[1] == Y) Console.ForegroundColor = ConsoleColor.Red;
                }
                foreach (int[] value in Blue)
                {
                    if (value[0] == X & value[1] == Y) Console.ForegroundColor = ConsoleColor.Blue;
                }
            }
            void Print1(string txt) { Console.Write(txt); }

            Print1("        ");
            for (int k = 0; k < Arr.GetLength(1); k++) { Print1($"{k:d2}" + "   "); }
            Print1("\n\n");
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                Print1($"Ряд {i:d2}  ");
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    ColorMark(i, j);
                    Print1($"{Arr[i, j]:d2}" + "   ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Print1("\n\n");
            }
        }

        public static class RandomR
        {
            public static Random r = new Random();
        }

        /// <summary>
        /// Замер времени выполнения участка кода.
        /// </summary>
        public static class SpeedTest
        {
            private static Stopwatch SW = new Stopwatch();

            /// <summary>
            /// Запуск таймера.
            /// </summary>
            public static void StartSW()
            {
                SW.Start();
            }

            /// <summary>
            /// Останавливает и сбрасывает таймер.
            /// </summary>
            /// <returns>Время выполнения формата 0,000</returns>
            public static string StopSW()
            {
                SW.Stop();
                double result = SW.ElapsedMilliseconds;
                SW.Reset();
                return $"{result/1000:F3}";
            }
        }

        public static class TextWriter
        {
            public static void CSVWriter(string Path, string[] Arr)
            {
                StreamWriter sw = null;
                try
                {
                    using (sw = new StreamWriter(Path))
                    {
                        foreach (string t in Arr)
                        {
                            sw.WriteLine(t);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    sw?.Close();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">
        /// 1 - gen firstname.
        /// 2 - gen lastname.
        /// </param>
        /// <returns></returns>
        public static string NameGenerator(int x)
        {
            string[] arrLastName = { "Иванов", "Петров", "Сидоров", "Пупкин", "Ложников",
                "Вилкин", "Новоселов", "Захаров", "Щукин", "Дорохов", "Воронин", "Ленин",
                "Петухов", "Горошин", "Полежаев", "Туркменов", "Южин", "Рогов", "Писарев",
                "Корнев"};
            string[] arrFirstName = { "Сергей", "Виталий", "Иван", "Николай", "Алексей",
                "Александр", "Михаил", "Владимир", "Светозар", "Артём", "Ренат", "Трофим",
                "Захар", "Каземир", "Павел", "Фёдор", "Яков", "Юлий", "Борис", "Эдуард", "Давид"};

            switch (x)
            {
                case 1:
                    return arrFirstName[RandomR.r.Next(0, 19)];                    
                case 2:
                    return arrLastName[RandomR.r.Next(0, 20)];                    
                default:
                    return "Ошибка ввода";
            }
        }
    }
}
