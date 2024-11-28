using System.IO;

namespace Tyuiu.BlagihIA.Sprint5.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask4V0.txt");

            FileInfo inf = new FileInfo(path);
            bool ex = inf.Exists;
            bool wait = true;

            Assert.AreEqual(wait, ex);

        }
    }
}