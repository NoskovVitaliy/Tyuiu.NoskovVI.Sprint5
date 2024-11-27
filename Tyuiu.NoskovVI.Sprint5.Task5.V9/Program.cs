using Tyuiu.NoskovVI.Sprint5.Task5.V9.Lib;
namespace Tyuiu.NoskovVI.Sprint5.Task5.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Носков В. И. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Носков Виталий Игоревич | ПКТб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Прочитать набор данных из файла и найти наибольшее целое                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Файл по пути :" + "C:\\DataSprint5\\InPutDataFileTask5V9.txt");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.LoadFromDataFile(@"C:\DataSprint5\InPutDataFileTask5V9.txt"));
        }
    }
}
