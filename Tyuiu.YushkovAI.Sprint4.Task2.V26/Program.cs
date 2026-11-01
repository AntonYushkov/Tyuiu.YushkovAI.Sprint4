using System.Text;
using Tyuiu.YushkovAI.Sprint4.Task2.V26.Lib;

namespace Tyuiu.YushkovAI.Sprint4.Task2.V26
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
            Console.WriteLine("* Тема: Одномерные массивы (случайные числа)                              *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Юшков Антон Ильич | ПКТб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Массив из 14 целых чисел заполнить случайными значениями от 1 до 8.     *");
            Console.WriteLine("* Подсчитать произведение нечётных элементов массива.                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Random rnd = new Random();
            int[] array = new int[14];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 9);
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
