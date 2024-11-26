namespace Tyuiu.NoskovVI.Sprint5.Task0.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestWriteText()
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask0.txt" });
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
