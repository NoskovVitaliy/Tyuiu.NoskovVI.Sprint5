using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NoskovVI.Sprint5.Task5.V9.Lib
{
    public class DataService : ISprint5Task5V9
    {
        public double LoadFromDataFile(string path)
        {
            int res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                while (reader.EndOfStream == false)
                {
                    int.TryParse(reader.ReadLine(), out int number);
                    if (number > res) res = number;
                }
            }
            return res;
        }
    }
}
