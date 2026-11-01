using System.Text;
using Tyuiu.YushkovAI.Sprint4.Task1.V12.Lib;

namespace Tyuiu.YushkovAI.Sprint4.Task1.V12
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
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Юшков Антон Ильич | ПКТб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Ввести 13 целых чисел в диапазоне от 4 до 9.                            *");
            Console.WriteLine("* Подсчитать произведение нечётных элементов массива.                     *");
            Console.WriteLine("* С клавиатуры: 4, 8, 6, 4, 9, 5, 8, 7, 8, 4, 7, 6, 8.                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = new int[13];
            for (int i = 0; i < array.Length; i++)
            {
                do
                {
                    Console.WriteLine($"Введите элемент {i + 1} (целое число от 4 до 9):");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
                while (array[i] < 4 || array[i] > 9);
            }
            Console.WriteLine($"Массив: {string.Join(", ", array)}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(array);
            Console.WriteLine($"Произведение нечётных элементов = {res}");
        }
    }
}
