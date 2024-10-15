using Tyuiu.ShabalinaYP.Sprint3.Task0.V21.Lib;
namespace Tyuiu.ShabalinaYP.Sprint3.Task0.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double a = 1.5;
            int start = 1;
            int end = 13;
            double res = ds.GetSumSeries(a, start, end);
            //double wait =
        }
    }
}