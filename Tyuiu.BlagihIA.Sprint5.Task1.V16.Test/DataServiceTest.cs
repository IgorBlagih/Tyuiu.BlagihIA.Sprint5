using Tyuiu.BlagihIA.Sprint5.Task1.V16.Lib;
using System.IO;
namespace Tyuiu.BlagihIA.Sprint5.Task1.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string direct = System.IO.Path.GetTempPath();



            string path = Path.GetTempFileName();
            string apath = Path.Combine(direct, path);

            FileInfo fileInfo = new FileInfo(apath);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(true, fileExist);
        }
    }
}