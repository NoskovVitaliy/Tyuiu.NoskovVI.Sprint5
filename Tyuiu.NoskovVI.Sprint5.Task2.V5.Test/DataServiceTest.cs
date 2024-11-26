namespace Tyuiu.NoskovVI.Sprint5.Task2.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckFile()
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask2.csv" });
            FileInfo file = new FileInfo(path);
            bool fileExists = file.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
