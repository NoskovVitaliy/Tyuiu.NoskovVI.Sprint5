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
                while (reader.EndOfStream == false)
                {
                    foreach(char symbol in reader.ReadLine())
                    {
                        if (symbol >= 'A' && symbol <='Z') count++; 
                    }
                }
            }
            return count;
        }
    }
}
