using Tyuiu.ShabalinaYP.Sprint3.Task2.V26.Lib;
namespace Tyuiu.ShabalinaYP.Sprint3.Task2.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            var dataService = new DataService();
            double value = 0.25;
            int x = 1;
            int y = 17;
            double wait = 2.741;
            double res = dataService.GetMultiplySeries(value, x, y);
            Assert.AreEqual(wait, res);
        }
    }
}