using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShabalinaYP.Sprint3.Task2.V26.Lib
{
    public class DataService : ISprint3Task2V26
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double res = 1;
            do
            {
                res = res * ((Math.Pow(value, 3) * startValue)+2);
                startValue++;
            }while (startValue <= stopValue);
            return Math.Round(res, 3);
        }
    }
}
