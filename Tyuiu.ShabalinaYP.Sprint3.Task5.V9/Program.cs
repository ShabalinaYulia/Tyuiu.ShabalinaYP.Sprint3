using Tyuiu.ShabalinaYP.Sprint3.Task5.V9.Lib;
namespace Tyuiu.ShabalinaYP.Sprint3.Task5.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("Спринт #3 | Выполнил: Шабалина Ю. П. | ПКТб-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Шабалина Юлия Павловна | ПКТб-24-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет значение функции                  *");
            Console.WriteLine("* и печатает результат на экране                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите значение X:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите первое начальное значение:");
            int startValue1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе начальное значение:");
            int startValue2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите первое конечное значение:");
            int stopValue1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе конечное значение:");
            int stopValue2 = Convert.ToInt32(Console.ReadLine());
            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Значение функции: " + res);
            Console.ReadKey();
        }
    }
}
