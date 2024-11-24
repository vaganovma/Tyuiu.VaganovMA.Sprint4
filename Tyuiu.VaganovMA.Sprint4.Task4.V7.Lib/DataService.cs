using tyuiu.cources.programming.interfaces.Sprint4; 
 
namespace Tyuiu.VaganovMA.Sprint4.Task4.V7.Lib;

public class DataService : ISprint4Task4V7
{
    public int Calculate(int[,] matrix)
    {
        //int l = 0;
        int s = 0;
        int rows = matrix.GetUpperBound(0) + 1;//кол строк
        int stolb = matrix.Length / rows;      //кол столбцов
        //int minzn = int.MaxValue;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < stolb; j++)
            {
                if (matrix[i, j] % 2 != 0 )
                {
                    s += matrix[i, j];
                }
            }
        }
        return s;
        
    }
} 
