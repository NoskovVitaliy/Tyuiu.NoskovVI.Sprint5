using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NoskovVI.Sprint5.Task6.V5.Lib
{
    public class DataService : ISprint5Task6V5
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                if (reader.EndOfStream == false)
                {
                    foreach(char symbol in reader.ReadToEnd())
                    {
                        if (char.IsUpper(symbol)) count++; 
                    }
                }
            }
            return count;
        }
    }
}
