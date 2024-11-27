using tyuiu.cources.programming.interfaces.Sprint5;
using System.Globalization;
using System.Text;
namespace Tyuiu.NoskovVI.Sprint5.Task4.V30.Lib
{
    public class DataService : ISprint5Task4V30
    {
        public double LoadFromDataFile(string path)
        {
            double x = Convert.ToDouble(File.ReadAllText(path).Replace('.',','));
            double y = ((x * x * x) - Math.Tan(x)) + 2.03 * x;
            return Math.Round(y,3);
        }
    }
}
