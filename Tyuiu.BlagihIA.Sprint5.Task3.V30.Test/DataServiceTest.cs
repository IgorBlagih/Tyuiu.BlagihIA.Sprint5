using System.IO;
using Tyuiu.BlagihIA.Sprint5.Task3.V30.Lib;
namespace Tyuiu.BlagihIA.Sprint5.Task3.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.GetTempFileName();

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(true, fileExist);
        }
    }
}