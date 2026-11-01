using System.Text;
using Tyuiu.YushkovAI.Sprint4.Task0.V5.Lib;

namespace Tyuiu.YushkovAI.Sprint4.Task0.V5
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
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Юшков Антон Ильич | ПКТб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан массив из 10 целых чисел в диапазоне от 0 до 9.                     *");
            Console.WriteLine("* Подсчитать сумму чётных элементов.                                      *");
            Console.WriteLine("* {8, 9, 4, 1, 2, 3, 4, 5, 6, 7}                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = { 8, 9, 4, 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine($"Массив: {string.Join(", ", array)}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.GetSumEvenArrEl(array);
            Console.WriteLine($"Сумма чётных элементов = {res}");
        }
    }
}
