using Tyuiu.ShabalinaYP.Sprint3.Task3.V4.Lib;
namespace Tyuiu.ShabalinaYP.Sprint3.Task3.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("Спринт #3 | Выполнил: Шабалина Ю. П. | ПКТб-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Шабалина Юлия Павловна | ПКТб-24-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая удаляет из строчки определенные символы     *");
            Console.WriteLine("* и печатает результат на экране                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите строку:");
            string value = Console.ReadLine();
            Console.WriteLine("Введите символ:");
            char item = Convert.ToChar(Console.ReadLine());
            string res = ds.DeleteCharInString(value, item);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Конечная строчка: " + res);
            Console.ReadKey();
        }
    }
}
