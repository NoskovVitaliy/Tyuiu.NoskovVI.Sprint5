using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NoskovVI.Sprint5.Task2.V5.Lib
{
    public class DataService : ISprint5Task2V5
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask2.csv" });
            string str = "";
            FileInfo file = new FileInfo(path);
            if (file.Exists) file.Delete();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] % 2 != 0) matrix[i, j] = 0;

                    if (j == columns - 1)
                    {
                        str += matrix[i, j].ToString();
                    }
                    else
                    {
                        str += matrix[i, j].ToString() + ";";
                    }
                }
                if (i == rows - 1)
                {
                    File.AppendAllText(path, str);
                }
                else
                {
                    File.AppendAllText(path,str+Environment.NewLine);
                }
                str = "";
            }
            return path;
        }
    }
}
