using Tyuiu.NoskovVI.Sprint5.Task7.V16.Lib;
namespace Tyuiu.NoskovVI.Sprint5.Task7.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Носков В. И. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка текстового файла                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Носков Виталий Игоревич | ПКТб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Прочитать набор данных из файла и заменить некоторые слова              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Файл находится по пути ...\\OutPutDataFileTask7V16.txt");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            ds.LoadDataAndSave(@"C:\DataSprint5\InPutDataFileTask7V16.txt");
            string text = File.ReadAllText(Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V16.txt" }));
            Console.WriteLine(text);
        }
    }
}
