using Tyuiu.VaganovMA.Sprint4.Task0.V5.Lib; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidGetSumEvenArrEl()  
   {
        DataService ds = new DataService();


        int[] numsArray = { 8, 9, 4, 1, 2, 3, 4, 5, 6, 7 };
        int res = ds.GetSumEvenArrEl(numsArray);
        int numWaitArray = 1536;

        Assert.AreEqual(numWaitArray, res);
    } 
} 
