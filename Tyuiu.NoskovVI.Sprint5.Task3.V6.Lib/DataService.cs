using tyuiu.cources.programming.interfaces.Sprint5;
using System.Text;
namespace Tyuiu.NoskovVI.Sprint5.Task3.V6.Lib
{
    public class DataService : ISprint5Task3V6
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask3.bin" });
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists) fileInfo.Delete(); 
            double y = Math.Round((double)x / (Math.Sqrt((double)x * (double)x + (double)x)), 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));
            }
            return path;
        }
    }
}
