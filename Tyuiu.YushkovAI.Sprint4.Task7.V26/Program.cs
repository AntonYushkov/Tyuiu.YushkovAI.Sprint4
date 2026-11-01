using System.Text;
using Tyuiu.YushkovAI.Sprint4.Task7.V26.Lib;

namespace Tyuiu.YushkovAI.Sprint4.Task7.V26
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
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Юшков Антон Игоревич | ПКТб-26-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"351268459614723\".                    *");
            Console.WriteLine("* Преобразовать её в матрицу 5 на 3.                                      *");
            Console.WriteLine("* Подсчитать произведение чётных чисел матрицы.                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int rows = 5;
            int columns = 3;
            string value = "351268459614723";
            Console.WriteLine("Исходная строка: " + value);
            Console.WriteLine("Количество строк = " + rows);
            Console.WriteLine("Количество столбцов = " + columns);
            int[,] matrix = new int[rows, columns];
            int index = 0;
            Console.WriteLine("Матрица:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = value[index] - '0';
                    Console.Write(matrix[i, j] + "\t");
                    index++;
                }
                Console.WriteLine();
            }
            int res = ds.Calculate(rows, columns, value);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведение чётных чисел матрицы: " + res);
        }
    }
}
