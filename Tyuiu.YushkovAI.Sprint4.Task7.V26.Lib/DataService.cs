using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.YushkovAI.Sprint4.Task7.V26.Lib
{
    public class DataService : ISprint4Task7V26
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            int res = 1;
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = value[index] - '0';
                    if (matrix[i, j] % 2 == 0)
                    {
                        res *= matrix[i, j];
                    }
                    index++;
                }
            }
            return res;
        }
    }
}
