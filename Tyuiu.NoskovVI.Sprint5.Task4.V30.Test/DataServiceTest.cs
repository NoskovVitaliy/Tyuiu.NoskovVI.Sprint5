namespace Tyuiu.NoskovVI.Sprint5.Task4.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void FileExists()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V30.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool exists = fileInfo.Exists;
            Assert.AreEqual(true, exists);
        }
    }
}
