namespace Tyuiu.NoskovVI.Sprint5.Task7.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void FileExists()
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V16.txt" });
            FileInfo file = new FileInfo(path);
            bool Exists = file.Exists;
            Assert.AreEqual(true, file.Exists);
        }
    }
}
