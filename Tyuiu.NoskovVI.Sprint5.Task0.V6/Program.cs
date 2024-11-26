using Tyuiu.NoskovVI.Sprint5.Task0.V6.Lib;
namespace Tyuiu.NoskovVI.Sprint5.Task0.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Носков В. И. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: класс File                                                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Носков Виталий Игоревич | ПКТб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Сохранить выражение в файл                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение x");
            int x = Convert.ToInt32(Console.ReadLine());
            ds.SaveToFileTextData(x);
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask0.txt" });
            string text = File.ReadAllText(path);
            Console.WriteLine(text);
        }
    }
}
