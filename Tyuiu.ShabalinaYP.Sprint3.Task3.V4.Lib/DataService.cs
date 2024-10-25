using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShabalinaYP.Sprint3.Task3.V4.Lib
{
    public class DataService : ISprint3Task3V4
    {
        public string DeleteCharInString(string value, char item)
        {
            foreach (char c in value)
            {
                if (c == item)
                {
                    value = value.Replace(c.ToString(), string.Empty);
                }
            }
            return value;
        }
    }
}
