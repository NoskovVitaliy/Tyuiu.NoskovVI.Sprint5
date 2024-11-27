namespace Tyuiu.NoskovVI.Sprint5.Task5.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void FileExists()
        {
            string path = @"С:\DataSprint5\InPutDataFileTask5V9.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
