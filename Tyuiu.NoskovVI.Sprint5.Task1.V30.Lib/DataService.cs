using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NoskovVI.Sprint5.Task1.V30.Lib
{
    public class DataService : ISprint5Task1V30
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask1.txt" });
            FileInfo fileInfo = new FileInfo(path);

            if (fileInfo.Exists) fileInfo.Delete();

            for (int x = startValue; x<= stopValue; x++)
            {
                double y;
                if (x != 1) { y = Math.Round(Math.Cos(x) + Math.Sin(x) / (2 - 2 * (double)x) - 4 * (double)x,2); }
                else { y = 0; }

                if (x == stopValue)
                {
                    File.AppendAllText(path, y.ToString());
                }
                else
                {
                    File.AppendAllText(path, y.ToString() + Environment.NewLine);
                }


            }
            return path;
        }
    }
}
