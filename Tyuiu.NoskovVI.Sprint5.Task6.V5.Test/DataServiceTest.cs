using Tyuiu.NoskovVI.Sprint5.Task6.V5.Lib;
namespace Tyuiu.NoskovVI.Sprint5.Task6.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CorrectCalc()
        {
            var ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V5.txt";
            int wait = 65;
            Assert.AreEqual(wait, ds.LoadFromDataFile(path));
        }

        [TestMethod]
        public void FileExists()
        {
            var ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V5.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool Exists = fileInfo.Exists;
            Assert.AreEqual(true, Exists);
        }
    }
}
