using System.Text;
using Tyuiu.YushkovAI.Sprint4.Task3.V6.Lib;

namespace Tyuiu.YushkovAI.Sprint4.Task3.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Юшков А. И. | ПКТб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Юшков Антон Ильич | ПКТб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана матрица 5 на 5 с целыми значениями от 3 до 8.                      *");
            Console.WriteLine("* Найти максимальный элемент во второй строке массива.                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] array = { { 8, 8, 3, 4, 5 }, { 8, 6, 6, 4, 6 },
                             { 3, 6, 5, 3, 4 }, { 5, 6, 3, 7, 5 },
                             { 7, 8, 5, 6, 6 } };
            Console.WriteLine("Массив:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Максимальный элемент во второй строке = " + ds.Calculate(array));
        }
    }
}
