using Tyuiu.ShabalinaYP.Sprint3.Task4.V23.Lib;
namespace Tyuiu.ShabalinaYP.Sprint3.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int start = -5;
            int end = 5;
            double res = ds.Calculate(start, end);
            double wait = 244,656;
            Assert.AreEqual(wait,res);


        }
    }
}