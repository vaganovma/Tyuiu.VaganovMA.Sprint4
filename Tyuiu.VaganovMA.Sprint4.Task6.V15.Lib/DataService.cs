using tyuiu.cources.programming.interfaces.Sprint4; 
 
namespace Tyuiu.VaganovMA.Sprint4.Task6.V15.Lib;

public class DataService : ISprint4Task6V15
{
    public int Calculate(string[] array)
    {        
        int count = array.Count(len => len.Length < 7);
       return count;
    }
} 
