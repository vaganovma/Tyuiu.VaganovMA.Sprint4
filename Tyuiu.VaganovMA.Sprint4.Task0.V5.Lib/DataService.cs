using tyuiu.cources.programming.interfaces.Sprint4; 
 
namespace Tyuiu.VaganovMA.Sprint4.Task0.V5.Lib;

public class DataService : ISprint4Task0V5
{
    public int GetSumEvenArrEl(int[] array)
    {
        int m = 0;
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                sum += array[i];
                m++;
            }
        }
        return sum;
    }
 } 
