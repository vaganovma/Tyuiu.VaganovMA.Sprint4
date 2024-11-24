using Tyuiu.VaganovMA.Sprint4.Task6.V15.Lib; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   { 
    DataService ds = new DataService(); 
   int[] numsArray = { 2, 2, 2, 5, 5, 3, 4, 2, 5, 2, 5, 3, 4, 3, 5, 2 }; 
   int res = ds.Calculate(numsArray); 
   int Wait = 84375; 
   Assert.AreEqual(Wait, res); 
   } 
} 
   //не делал!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! 
