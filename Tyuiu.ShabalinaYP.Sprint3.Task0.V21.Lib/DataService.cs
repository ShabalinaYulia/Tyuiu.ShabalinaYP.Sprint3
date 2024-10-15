using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShabalinaYP.Sprint3.Task0.V21.Lib
{
    public class DataService : ISprint3Task0V21
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double res;
            res = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                res = res + ((Math.Pow(value, i) + 0.25)*Math.Sin(i));
            }
            return Math.Round(res, 3);

        }
    }
}
