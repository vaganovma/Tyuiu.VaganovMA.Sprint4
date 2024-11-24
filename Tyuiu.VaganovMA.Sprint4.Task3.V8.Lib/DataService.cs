using tyuiu.cources.programming.interfaces.Sprint4; 
 
namespace Tyuiu.VaganovMA.Sprint4.Task3.V8.Lib;

public class DataService : ISprint4Task3V8
{
    public int Calculate(int[,] array)
    {
        int l = 0;
        int s = 1;
        int rows = array.GetUpperBound(0) + 1;//кол строк
        int stolb = array.Length / rows;      //кол столбцов
        int minzn = int.MaxValue;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (array[i, 3] < minzn)
                {
                    minzn = array[i, 3];
                }
            }
        }
        return minzn;
    }
}

