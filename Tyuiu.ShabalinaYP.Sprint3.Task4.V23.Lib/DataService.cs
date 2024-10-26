using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShabalinaYP.Sprint3.Task4.V23.Lib
{
    public class DataService : ISprint3Task4V23
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (i == 0)
                {
                    break;
                }
                else
                {
                    res = res * ((Math.Cos(i) / i) + 3);
                }
            }
            return Math.Round(res, 3);
        }
    }
}
