﻿using Tyuiu.ShabalinaYP.Sprint3.Task1.V14.Lib;
namespace Tyuiu.ShabalinaYP.Sprint3.Task1.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Спринт #3 | Выполнил: Шабалина Ю. П. | ПКТб-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла while                                              *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Шабалина Юлия Павловна | ПКТб-24-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет сумму ряда                        *");
            Console.WriteLine("* и печатает результат на экране                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите значение X:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Z:");
            int z = Convert.ToInt32(Console.ReadLine());
            double res = ds.GetSumSeries(x, y, z);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма ряда: " + res);
            Console.ReadKey();
        }
    }
}
