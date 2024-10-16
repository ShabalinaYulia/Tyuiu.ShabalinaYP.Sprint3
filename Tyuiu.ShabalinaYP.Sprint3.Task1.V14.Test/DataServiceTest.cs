using System.Transactions;
using Tyuiu.ShabalinaYP.Sprint3.Task1.V14.Lib;
namespace Tyuiu.ShabalinaYP.Sprint3.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            var ds = new DataService();
            double value = 0.7;
            int startValue = 1;
            int stopValue = 14;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 3.546;
            Assert.AreEqual(res, wait);

        }
    }
}