using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.YushkovAI.Sprint4.Task4.V19.Lib
{
    public class DataService : ISprint4Task4V19
    {
        public int Calculate(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % 2 != 0)
                    {
                        sum += array[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
