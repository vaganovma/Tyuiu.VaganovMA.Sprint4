using Tyuiu.VaganovMA.Sprint4.Task1.V24.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void Calculate()
    {
        DataService ds = new DataService();


        int[] numsArray = { 8, 9, 4, 1, 2, 3, 4, 5, 6, 7 };
        int res = ds.Calculate(numsArray);
        int numWaitArray = 24;

        Assert.AreEqual(numWaitArray, res);
    }
}
