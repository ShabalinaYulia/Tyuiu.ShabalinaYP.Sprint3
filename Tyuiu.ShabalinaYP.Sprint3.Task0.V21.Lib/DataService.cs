using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShabalinaYP.Sprint3.Task0.V21.Lib
{
    public class DataService : ISprint3Task0V21
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double res;
            res = 0;
            for (int k = startValue; k < stopValue; k++)
            {
                res += ((Math.Pow(value, k) + (1 / 4)) * Math.Sin(k));
            }
            return res;

        }
    }
}
